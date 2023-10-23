using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class Producto
	{
		#region Atributos

		private int idProducto;
		private int codigo;
		private string nombreProducto;
		private string descripcion;
		private bool estado;
		private int cantidad;
		private int idDeposito;

		#endregion

		#region constructores

		public Producto()
		{ }

		public Producto(int IdProducto, int Codigo, string NombreProducto, string Descripcion, bool Estado, int Cantidad, int IdDeposito)
		{
			this.idProducto = IdProducto;
			this.codigo = Codigo;
			this.nombreProducto = NombreProducto;
			this.descripcion = Descripcion;
			this.estado = Estado;
			this.cantidad = Cantidad;
			this.idDeposito = IdDeposito;
		}

        public Producto(int Codigo, string NombreProducto, string Descripcion, bool Estado, int Cantidad, int IdDeposito)
        {
            this.codigo = Codigo;
            this.nombreProducto = NombreProducto;
            this.descripcion = Descripcion;
            this.estado = Estado;
            this.cantidad = Cantidad;
            this.idDeposito = IdDeposito;
        }

        #endregion

        #region Metodos
        public void Cargar()
		{

		}
		#endregion

		public int IdProducto { get { return idProducto; } set { idProducto = value; } }
		public int Codigo { get { return codigo; } set { codigo = value; } }
		public string NombreProducto { get { return nombreProducto; } set { nombreProducto = value; } }
		public string Descripcion { get { return descripcion; } set { descripcion = value; } }
		public bool Estado { get { return estado; } set { estado = value; } }
		public int Cantidad { get { return cantidad; } set { cantidad = value; } }
		public int IdDeposito { get { return idDeposito; } set { idDeposito = value; } }
	}
}
