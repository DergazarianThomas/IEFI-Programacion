using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocios;

namespace IEFI_programacion
{
    public partial class Form1 : Form
    {

        const string ERROR_CODIGO = "Codigo repetido";
        const string ERROR_CAMPOS = "Llene los campos";


        Obra NuevaObra;
        Obra ObraExistente;
        Deposito NuevoDepo;
        Deposito DepoExistente;
        Producto NuevoProd;
        Producto ProdExistente;

        public NegDepositos objNegDepositos = new NegDepositos();
        public NegObras objNegObras = new NegObras();
        public NegProductos objNegProds = new NegProductos();

        public Form1()
        {
            InitializeComponent();
            CrearDGVs();

            LlenarDGVObras();
            LlenarCombos();
            LlenarDGVDepo();
            LlenarDGVProd();
        }

        private void LlenarDGVObras()
        {
            dgvObras.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegObras.listadoObras("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvObras.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            else
                lblObrasCargadas.Text = "No existen Obras cargados en el sistema";
        }

        private void LlenarDGVDepo()
        {
            dgvDepo.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegDepositos.listadoDepositos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvDepo.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
            }
            else
                lblDepoCargado.Text="No existen Depositos cargados en el sistema";
        }

        private void LlenarDGVProd()
        {
            dgvProd.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProds.listadoProductos("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvObras.Rows.Add(dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
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

        void LlenarCombos()
        {
            cbxVerObra.ValueMember = "IdObra";
            cbxVerObra.DisplayMember = "NombreObra";
            cbxVerObra.DataSource = objNegObras.ObtenerObras();

            cbxNumObra.ValueMember = "IdObra";
            cbxNumObra.DisplayMember = "NombreObra";
            cbxNumObra.DataSource = objNegObras.ObtenerObras();

            cbxDepo.ValueMember = "IdDeposito";
            cbxDepo.DisplayMember = "NombreDeposito";
            cbxDepo.DataSource = objNegDepositos.ObtenerDepositos();

            cbxVerDepo.ValueMember = "IdDeposito";
            cbxVerDepo.DisplayMember = "NombreDeposito";
            cbxVerDepo.DataSource = objNegDepositos.ObtenerDepositos();

        }

        private void btnAgregarObra_Click(object sender, EventArgs e)
        {
            if (!ValidarTabla(this.Controls))
            {

                int fila = 1;

                //if (objNegCelular.listadoCelulares(txtCodigo.Text)== ){ }

                if (ValidarCodigoUnicoObras(int.Parse(txtNumObra.Text)) == true)
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
                else
                {
                    MessageBox.Show(ERROR_CODIGO);
                }
            }
            LlenarCombos();
        }

        private bool ValidarTabla(Control.ControlCollection ctrlCollection)
        {
            bool bandera = false;

            // Validar campos vacios para datagrid

            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    if (!ctrl.Text.Any())
                    {
                        bandera = true;

                        MessageBox.Show(this, ERROR_CAMPOS, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        break;
                    };
                }
            }
            return bandera;
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

        public void LimpiarPantalla()
        {
            txtNumObra.Text = "";
            txtNombrObra.Text = "";
            txtDirecObra.Text = "";
        }

        private void btnAgregarDepo_Click(object sender, EventArgs e)
        {
            if (!ValidarTabla(this.Controls))
            {

                int fila = 1;

                //if (objNegCelular.listadoCelulares(txtCodigo.Text)== ){ }

                if (ValidarCodigoUnicoDepo(int.Parse(txtNumrDeposito.Text)) == true)
                {
                    int nGrabados = -1;

                    NuevoDepo = new Deposito(int.Parse(txtNumrDeposito.Text), txtNombrDepo.Text, txtDireccDepo.Text, Convert.ToInt32(cbxNumObra.SelectedValue) );

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
                    }
                }
                else
                {
                    MessageBox.Show(ERROR_CODIGO);
                }
            }
            LlenarCombos();
        }
    }
    
}

