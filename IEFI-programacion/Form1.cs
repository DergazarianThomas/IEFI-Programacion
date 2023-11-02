using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace IEFI_programacion
{
    public partial class Form1 : Form
    {
        #region errores
        const string ERROR_NUM = "Numero repetido";
        const string ERROR_SOLO_NUM = "Solo se admiten numeros";
        const string ERROR_NUM_NEC = "Numero Necesario";
        const string ERROR_NOM_NEC = "Nombre necesario";
        const string ERROR_DIR_NEC = "Direccion necesaria";
        const string ERROR_COD_NEC = "Codigo necesario";
        const string ERROR_INEXISTENTE = "El elemento no existe";
        

        #endregion

        #region inicializar
        Obra NuevaObra;
        Obra ObraExistente;
        Deposito NuevoDepo;
        Deposito DepoExistente;
        Producto NuevoProd;
        Producto ProdExistente;

        public NegDepositos objNegDepositos = new NegDepositos();
        public NegObras objNegObras = new NegObras();
        public NegProductos objNegProds = new NegProductos();
        #endregion

        public Form1()
        {

            InitializeComponent();

            #region iniciar_creacion_&_llenado_dgv
            CrearDGVs();
            LlenarDGVObras();
            LlenarCombosObra();
            LlenarCombosDepo();
            LlenarDGVDepo();
            LlenarDGVProd();
            #endregion
        }

        #region creacion_llenado_Dgvs
        private void LlenarDGVObras()
        {
            dgvObras.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegObras.listadoObras("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvObras.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
                lblObrasCargadas.Text = "No existen Obras cargados en el sistema";
        }

        private void LlenarDGVDepo()
        {
            lblDepoCargado.Text = "";
            dgvDepo.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegDepositos.listadoDepositos(Convert.ToString(cbxVerObra.SelectedValue));
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvDepo.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
                }
            }
            else
                lblDepoCargado.Text="No existen Depositos cargados en el sistema";
        }


        private void LlenarDGVProd()
        {
            dgvProd.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProds.listadoProductos(Convert.ToString(cbxVerDepo.SelectedValue));
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvProd.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
                }
            }
            else

                lblProdCargados.Text = "No existen Productos cargados en el sistema";
        }
        
        private void CrearDGVs()
        {
            dgvObras.Columns.Add("0", "Numero");
            dgvObras.Columns.Add("1", "Nombre");
            dgvObras.Columns.Add("2", "Direccion");
            dgvObras.Columns.Add("3", "Fecha");


            dgvObras.Columns[0].Width = 50;
            dgvObras.Columns[1].Width = 120;
            dgvObras.Columns[2].Width = 202;
            dgvObras.Columns[3].Width = 120;

            dgvDepo.Columns.Add("0", "Numero");
            dgvDepo.Columns.Add("1", "Nombre");
            dgvDepo.Columns.Add("2", "Direccion");
            dgvDepo.Columns.Add("3", "Obra");

            dgvDepo.Columns[0].Width = 50;
            dgvDepo.Columns[1].Width = 120;
            dgvDepo.Columns[2].Width = 202;
            dgvDepo.Columns[3].Width = 120;

            dgvProd.Columns.Add("0", "Codigo");
            dgvProd.Columns.Add("1", "Nombre");
            dgvProd.Columns.Add("2", "Descripcion");
            dgvProd.Columns.Add("3", "Estado");
            dgvProd.Columns.Add("4", "Cantidad");
            dgvProd.Columns.Add("5", "Deposito");

            dgvProd.Columns[0].Width = 50;
            dgvProd.Columns[1].Width = 120;
            dgvProd.Columns[2].Width = 220;
            dgvProd.Columns[3].Width = 100;
            dgvProd.Columns[4].Width = 100;
            dgvProd.Columns[5].Width = 220;
        }
        #endregion

        #region llenado_comboboxs
        void LlenarCombosObra()
        {
            cbxVerObra.SelectedIndex = -1;
            cbxVerObra.ValueMember = "IdObra";
            cbxVerObra.DisplayMember = "NombreObra";
            cbxVerObra.DataSource = objNegObras.ObtenerObras();


            cbxNumObra.SelectedIndex = -1;
            cbxNumObra.ValueMember = "IdObra";
            cbxNumObra.DisplayMember = "NombreObra";
            cbxNumObra.DataSource = objNegObras.ObtenerObras();
            cbxNumObra.SelectedIndex = -1;

            
        }
        void LlenarCombosDepo()
        {
            cbxDepo.SelectedIndex = -1;
            cbxDepo.ValueMember = "IdDeposito";
            cbxDepo.DisplayMember = "NombreDeposito";
            cbxDepo.DataSource = objNegDepositos.ObtenerDepositos();

            cbxVerDepo.SelectedIndex = -1;
            cbxVerDepo.ValueMember = "IdDeposito";
            cbxVerDepo.DisplayMember = "NombreDeposito";
            cbxVerDepo.DataSource = objNegDepositos.ObtenerDepositos();
        }

        #endregion

        #region logica_botones
        private void btnAgregarObra_Click(object sender, EventArgs e)
        {
            if (!ValidarObra())
            {
                if (ValidarCodigoUnicoObras(int.Parse(txtNumObra.Text)) == false)
                {
                    errorProvider1.SetError(txtNumObra, ERROR_NUM);
                }
                else
                {
                    int nGrabados = -1;

                    NuevaObra = new Obra(int.Parse(txtNumObra.Text), txtNombrObra.Text, txtDirecObra.Text, dtpFechaObra.Value);

                    nGrabados = objNegObras.abmObras("Alta", NuevaObra);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo cargar la obra en el sistema");
                    }
                    else
                    {
                        MessageBox.Show("La obra se guardo con éxito.");
                        LlenarDGVObras();
                        LimpiarPantalla();
                    }
                }
            }
            LlenarCombosObra();
        }

        private void btnAgregarDepo_Click(object sender, EventArgs e)
        {
            if (!ValidarDeposito())
            {
                if (ValidarCodigoUnicoDepo(int.Parse(txtNumrDeposito.Text)) == false)
                {
                    errorProvider1.SetError(txtNumrDeposito, ERROR_NUM);
                }
                else 
                {
                    int nGrabados = -1;

                    NuevoDepo = new Deposito(int.Parse(txtNumrDeposito.Text), txtNombrDepo.Text, txtDireccDepo.Text, Convert.ToInt32(cbxNumObra.SelectedValue));

                    nGrabados = objNegDepositos.abmDepositos("Alta", NuevoDepo);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo cargar el Deposito en el sistema");
                    }
                    else
                    {
                        MessageBox.Show("El deposito se guardo con éxito.");
                        LlenarDGVDepo();
                        LimpiarPantalla();
                        LlenarCombosDepo();
                    }
                    
                }
            }
            LlenarCombosDepo();
        }

        private void btnBorrObra_Click(object sender, EventArgs e)
        {
            if (!validarBorrarObra())
            {
                if (ValidarCodigoUnicoObras(int.Parse(txtBorrObra.Text)))
                {
                    errorProvider1.SetError(txtBorrObra, ERROR_INEXISTENTE);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar la obra numero " + txtBorrObra.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        int nGrabados = -1;
                        NuevaObra = new Obra(int.Parse(txtBorrObra.Text));
                        nGrabados = objNegObras.abmObras("Borrar", NuevaObra);
                        LlenarDGVObras();
                        txtBorrObra.Text = "";

                    }

                    LlenarCombosObra();
                    errorProvider1.Clear();
                    LlenarDGVDepo();
                    LlenarCombosDepo();
                    LlenarDGVProd();
                    LimpiarPantalla();
                }
            }

        }

        private void btnModfObra_Click(object sender, EventArgs e)
        {
            if (!ValidarObra())
            {
                if (ValidarCodigoUnicoObras(int.Parse(txtNumObra.Text)))
                {
                    errorProvider1.SetError(txtNumObra, ERROR_INEXISTENTE);
                }
                else
                {
                    int nResultado = -1;

                    NuevaObra = new Obra(int.Parse(txtNumObra.Text), txtNombrObra.Text, txtDirecObra.Text, dtpFechaObra.Value);

                    nResultado = objNegObras.abmObras("Modificar", NuevaObra); //invoco a la capa de negocio

                    if (nResultado != 0 || nResultado != -1)
                    {
                        MessageBox.Show("La obra fue modificada con éxito", "Aviso");

                        LimpiarPantalla();
                        LlenarDGVObras();
                        LlenarCombosObra();
                        LlenarCombosDepo();
                        txtNumObra.Enabled = true;
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar modificar la obra", "Error");
                }
            }

        }

        private void btnModfDepo_Click(object sender, EventArgs e)
        {
            if (!ValidarDeposito())
            {
                if (ValidarCodigoUnicoDepo(int.Parse(txtNumrDeposito.Text)))
                {
                    errorProvider1.SetError(txtNumrDeposito, ERROR_INEXISTENTE);
                }
                else
                {
                    int nResultado = -1;

                    NuevoDepo = new Deposito(int.Parse(txtNumrDeposito.Text), txtNombrDepo.Text, txtDireccDepo.Text, Convert.ToInt32(cbxNumObra.SelectedValue));

                    nResultado = objNegDepositos.abmDepositos("Modificar", NuevoDepo); //invoco a la capa de negocio

                    if (nResultado != 0 || nResultado != -1)
                    {
                        MessageBox.Show("El deposito fue modificado con éxito", "Aviso");
                        LimpiarPantalla();
                        LlenarDGVDepo();
                        LlenarCombosDepo();
                        LimpiarPantalla();

                        txtNumrDeposito.Enabled = true;
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar modificar el deposito", "Error");
                }
            }
        }

        private void btnBorrarDepo_Click(object sender, EventArgs e)
        {
            if (!validarBorrarDepo())
            {
                if (ValidarCodigoUnicoDepo(int.Parse(txtBorrDepo.Text)))
                {
                    errorProvider1.SetError(txtBorrDepo, ERROR_INEXISTENTE);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el deposito numero " + txtBorrDepo.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        int nGrabados = -1;
                        NuevoDepo = new Deposito(int.Parse(txtBorrDepo.Text));
                        nGrabados = objNegDepositos.abmDepositos("Borrar", NuevoDepo);
                        LlenarDGVDepo();
                        txtBorrDepo.Text = "";

                    }
                    LlenarCombosDepo();
                    errorProvider1.Clear();
                    LlenarDGVProd();
                    LimpiarPantalla();
                }
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (!ValidarProducto())
            {
                if (ValidarCodigoUnicoProd(int.Parse(txtCodProd.Text)) == false)
                {
                    errorProvider1.SetError(txtCodProd, ERROR_NUM);
                }
                else
                {
                    int nGrabados = -1;

                    NuevoProd = new Producto(int.Parse(txtCodProd.Text), txtNombrProd.Text, txtDescrProd.Text, chbEstadoProd.Checked, int.Parse(txtCantProd.Text), Convert.ToInt32(cbxVerDepo.SelectedValue));

                    nGrabados = objNegProds.abmProductos("Alta", NuevoProd);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo cargar el Producto en el sistema");
                    }
                    else
                    {
                        MessageBox.Show("El Producto se guardo con éxito.");
                       LlenarDGVProd();
                        LimpiarPantalla();
                      
                    }

                }
            }
     
        }

        private void btnModProd_Click(object sender, EventArgs e)
        {
            if (!ValidarProducto())
            {
                if (ValidarCodigoUnicoProd(int.Parse(txtCodProd.Text)))
                {
                    errorProvider1.SetError(txtCodProd, ERROR_INEXISTENTE);
                }
                else
                {
                    int nResultado = -1;

                    NuevoProd = new Producto(int.Parse(txtCodProd.Text), txtNombrProd.Text, txtDescrProd.Text, chbEstadoProd.Checked, int.Parse(txtCantProd.Text), Convert.ToInt32(cbxVerDepo.SelectedValue));

                    nResultado = objNegProds.abmProductos("Modificar", NuevoProd); //invoco a la capa de negocio

                    if (nResultado != 0 || nResultado != -1)
                    {
                        MessageBox.Show("El Producto fue modificado con éxito", "Aviso");
                        LimpiarPantalla();
                        LlenarDGVProd();
                        LlenarDGVProd();

                        txtCodProd.Enabled = true;
                    }
                    else
                        MessageBox.Show("Se produjo un error al intentar modificar el producto", "Error");
                }
            }

        }

        private void btnBorrarProd_Click(object sender, EventArgs e)
        {
            if (!validarBorrarProd())
            {
                if (ValidarCodigoUnicoProd(int.Parse(txtBorrProd.Text)))
                {
                    errorProvider1.SetError(txtBorrProd, ERROR_INEXISTENTE);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro que desea eliminar el Producto numero " + txtBorrProd.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        int nGrabados = -1;
                        NuevoProd = new Producto(int.Parse(txtBorrProd.Text));
                        nGrabados = objNegProds.abmProductos("Borrar", NuevoProd);
                        LlenarDGVProd();
                        txtBorrProd.Text = "";

                    }
                    LimpiarPantalla();
                    LlenarCombosDepo();
                    errorProvider1.Clear();
                    LlenarDGVProd();
                }
            }
        }
        #endregion

        #region validaciones
        private bool ValidarObra()
        {
            errorProvider1.Clear();
            bool error = false;
            // Validar campos vacios
            if (String.IsNullOrEmpty(txtNumObra.Text))
            {
                errorProvider1.SetError(txtNumObra, ERROR_NUM_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtNombrObra.Text))
            {
                errorProvider1.SetError(txtNombrObra, ERROR_NOM_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtDirecObra.Text))
            {
                errorProvider1.SetError(txtDirecObra, ERROR_DIR_NEC);
                error = true;
            }

            if ( Regex.IsMatch(txtNumObra.Text,"[^0-9]"))
            {
                errorProvider1.SetError(txtNumObra, ERROR_SOLO_NUM);
                error = true;
            }

            return error;
        }

        private bool ValidarCodigoUnicoObras(int codigo)
        {
            foreach (DataGridViewRow row in dgvObras.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false;


                }

            }
            return true;
        }

        private bool ValidarCodigoUnicoDepo(int codigo)
        {
            foreach (DataGridViewRow row in dgvDepo.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidarCodigoUnicoProd(int codigo)
        {
            foreach (DataGridViewRow row in dgvProd.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == codigo.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        private bool validarBorrarObra()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtBorrObra.Text))
            {
                errorProvider1.SetError(txtBorrObra, ERROR_NUM_NEC);
                error = true;
            }

            if (Regex.IsMatch(txtBorrObra.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtBorrObra, ERROR_SOLO_NUM);
                error = true;
            }
            return error;
        }

        private bool validarBorrarDepo()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtBorrDepo.Text))
            {
                errorProvider1.SetError(txtBorrDepo, ERROR_NUM_NEC);
                error = true;
            }

            if (Regex.IsMatch(txtBorrDepo.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtBorrDepo, ERROR_SOLO_NUM);
                error = true;
            }
            return error;
        }

        private bool validarBorrarProd()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtBorrProd.Text))
            {
                errorProvider1.SetError(txtBorrProd, ERROR_NUM_NEC);
                error = true;
            }

            if (Regex.IsMatch(txtBorrProd.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtBorrProd, ERROR_SOLO_NUM);
                error = true;
            }
            return error;
        }

        private bool ValidarDeposito()
        {
            errorProvider1.Clear();
            bool error = false;
            // Validar campos vacios
            if (String.IsNullOrEmpty(txtNumrDeposito.Text))
            {
                errorProvider1.SetError(txtNumrDeposito, ERROR_NUM_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtNombrDepo.Text))
            {
                errorProvider1.SetError(txtNombrDepo, ERROR_NOM_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtDireccDepo.Text))
            {
                errorProvider1.SetError(txtDireccDepo, ERROR_DIR_NEC);
                error = true;
            }

            if (Regex.IsMatch(txtNumrDeposito.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtNumrDeposito, ERROR_SOLO_NUM);
                error = true;
            }

            return error;
        }

        private bool ValidarProducto()
        {
            errorProvider1.Clear();
            bool error = false;
            // Validar campos vacios
            if (String.IsNullOrEmpty(txtCodProd.Text))
            {
                errorProvider1.SetError(txtCodProd, ERROR_COD_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtNombrProd.Text))
            {
                errorProvider1.SetError(txtNombrProd, ERROR_NOM_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtDescrProd.Text))
            {
                errorProvider1.SetError(txtDescrProd, ERROR_DIR_NEC);
                error = true;
            }

            if (String.IsNullOrEmpty(txtCantProd.Text))
            {
                errorProvider1.SetError(txtDescrProd, ERROR_DIR_NEC);
                error = true;
            }

            if (Regex.IsMatch(txtCantProd.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtCantProd, ERROR_SOLO_NUM);
                error = true;
            }
            if (Regex.IsMatch(txtCodProd.Text, "[^0-9]"))
            {
                errorProvider1.SetError(txtCodProd, ERROR_SOLO_NUM);
                error = true;
            }


            return error;
        }

        #endregion


        public void LimpiarPantalla()
        {
            txtNumObra.Text = "";
            txtNombrObra.Text = "";
            txtDirecObra.Text = "";
            txtBorrObra.Text = "";
            txtNombrDepo.Text = "";
            txtNumrDeposito.Text = "";
            txtDireccDepo.Text = "";
            txtBorrDepo.Text = "";
            txtNombrProd.Text = "";
            txtDescrProd.Text = "";
            txtCantProd.Text = "";
            txtBorrProd.Text = "";
            txtCodProd.Text = "";
            chbEstadoProd.Checked = false;
        }

        // evento para llenar dgvDeposito y dgvProductos cuando combobox cambia
        private void cbxVerObra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDGVDepo();
        }

        private void cbxVerDepo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDGVProd();
        }


        private void CrearReportePdf(DataGridView dataGridView, string outputPath)
        {
            PdfWriter writer = new PdfWriter(outputPath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            // Crea la tabla con las columnas que tenga el dataGridView
            iText.Layout.Element.Table pdfTable = new iText.Layout.Element.Table(dataGridView.Columns.Count);

            // Añade titulos
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                pdfTable.AddCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }

            pdfTable.

            // Añade los datos del DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Valida si es nulo
                    if (cell != null && cell.Value != null)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                    }
                    else
                    {
                        // En caso de que sea null
                        pdfTable.AddCell(new Cell().Add(new Paragraph("")));
                    }
                }
            }

            pdfTable.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            // Añade la tabla al documento
            doc.Add(pdfTable);

            doc.Close();
        }

        private void btnReporteProd_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgvProd, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }

        private void btnReporteObra_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgvObras, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }

        private void btnReporteDepo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPath = saveFileDialog.FileName;
                CrearReportePdf(dgvDepo, outputPath);
                MessageBox.Show("Reporte generado exitosamente!");
            }
        }
    }
    
}

