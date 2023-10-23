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
		private int numeroObra;
		private string nombreObra;
		private string direccion;
		private DateTime fechaCreacion;

		#endregion

		#region constructores

		public Obra()
		{ }

		public Obra(int IdObra, int NumeroObra ,string NombreObra, string Direccion, DateTime FechaCreacion)
		{
			this.idObra = IdObra;
			this.numeroObra = NumeroObra;
			this.nombreObra = NombreObra;
			this.direccion = Direccion;
			this.fechaCreacion = FechaCreacion;
		}

        public Obra(int NumeroObra, string NombreObra, string Direccion, DateTime FechaCreacion)
        {
            this.numeroObra = NumeroObra;
            this.nombreObra = NombreObra;
            this.direccion = Direccion;
            this.fechaCreacion = FechaCreacion;
        }
        public Obra(int NumeroObra)
        {
            this.numeroObra = NumeroObra;
        }

        #endregion

        #region Metodos
        public void Cargar()
		{

		}
		#endregion

		public int IdObra { get { return idObra; } set { idObra = value; } }
		public int NumeroObra { get { return numeroObra; } set { numeroObra = value; } }
		public string NombreObra { get { return nombreObra; } set { nombreObra = value; } }
		public string Direccion { get { return direccion; } set { direccion = value; } }
        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
    }
}
