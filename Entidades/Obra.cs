using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class Obra
	{
		#region Atributos

		private int idObra;
		private string nombreObra;
		private string direccion;

		#endregion

		#region constructores

		public Obra()
		{ }

		public Obra(int IdObra, string NombreObra, string Direccion)
		{
			this.idObra = IdObra;
			this.nombreObra = NombreObra;
			this.direccion = Direccion;
		}

		#endregion

		#region Metodos
		public void Cargar()
		{

		}
		#endregion

		public int IdObra { get { return idObra; } set { idObra = value; } }
		public string NombreObra { get { return nombreObra; } set { nombreObra = value; } }
		public string Direccion { get { return direccion; } set { direccion = value; } }
	}
}
