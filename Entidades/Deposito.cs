using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class Deposito
	{
		#region Atributos

		private int idDeposito;
		private int numeroDeposito;
		private string nombreDeposito;
		private string direccion;
		private int idObra;

		#endregion

		#region constructores

		public Deposito()
		{ }

		public Deposito(int IdDeposito,int NumeroDeposito, string NombreDeposito, string Direccion, int IdObra)
		{
			this.idDeposito = IdDeposito;
			this.numeroDeposito = NumeroDeposito;
			this.nombreDeposito = NombreDeposito;
			this.direccion = Direccion;
			this.idObra = IdObra;

		}

        public Deposito(int NumeroDeposito, string NombreDeposito, string Direccion, int IdObra)
        {
            this.numeroDeposito = NumeroDeposito;
            this.nombreDeposito = NombreDeposito;
            this.direccion = Direccion;
            this.idObra = IdObra;

        }

        #endregion

        #region Metodos
        public void Cargar()
		{

		}
		#endregion

		public int IdDeposito { get { return idDeposito; } set { idDeposito = value; } }
        public int NumeroDeposito { get { return numeroDeposito; } set { numeroDeposito = value; } }
        public string NombreDeposito { get { return nombreDeposito; } set { nombreDeposito = value; } }
		public string Direccion { get { return direccion; } set { direccion = value; } }
		public int IdObra { get { return idObra; } set { idObra = value; } }
	}
}
