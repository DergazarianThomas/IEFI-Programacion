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
        public NegDepositos objNegDepositos = new NegDepositos();
        public NegObras objNegObras = new NegObras();
        public NegProductos objNegProds = new NegProductos();
        public Form1()
        {
            InitializeComponent();
            CrearDGVObras();
            LlenarDGVObras();

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
                MessageBox.Show("No hay Obras cargadas en el sistema");
        }

        private void CrearDGVObras()
        {
            dgvObras.Columns.Add("0", "Numero");
            dgvObras.Columns.Add("1", "Nombre");
            dgvObras.Columns.Add("2", "Direccion");
            dgvObras.Columns.Add("3", "Fecha");


            dgvObras.Columns[0].Width = 50;
            dgvObras.Columns[1].Width = 120;
            dgvObras.Columns[2].Width = 202;
            dgvObras.Columns[3].Width = 120;
        }

        void LlenarCombos()
        { //llena un combo desde una lista con descripcion y código
            cbxVerObra.DataSource = objNegObras.ObtenerObras(); // se define el origen con la Lista
            cbxVerObra.DisplayMember = "NombreObra";
            cbxVerObra.ValueMember = "IdObra";
        }

        private void btnAgregarObra_Click(object sender, EventArgs e)
        {
            if (!ValidarTabla(this.Controls))
            {

                int fila = 1;

                //if (objNegCelular.listadoCelulares(txtCodigo.Text)== ){ }

                if (ValidarCodigoUnico(int.Parse(txtNumObra.Text)) == true)
                {
                    int nGrabados = -1;

                    NuevaObra = new Obra(int.Parse(txtNumObra.Text), txtNombrObra.Text, txtDirecObra.Text, dtpFechaObra.Value);

                    nGrabados = objNegObras.abmObras("Alta", NuevaObra);

                    if (nGrabados == -1)
                    {
                        MessageBox.Show("No se pudo Cargar Celular en el sistema");
                    }
                    else
                    {
                        MessageBox.Show("Se grabó con éxito el Celular.");
                        LlenarDGVObras();
                        LimpiarPantalla();
                    }
                }
                else
                {
                    MessageBox.Show(ERROR_CODIGO);
                }
            }
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

        private bool ValidarCodigoUnico(int codigo)
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

        public void LimpiarPantalla()
        {
            txtNumObra.Text = "";
            txtNombrObra.Text = "";
            txtDirecObra.Text = "";
        }

    }
}

