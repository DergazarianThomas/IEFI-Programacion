using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocios
{
	public class NegDepositos
	{

		AdministrarDepositos DatosObjDepositos = new AdministrarDepositos();

		public int abmDepositos(string accion, Deposito objDeposito)
		{
			return DatosObjDepositos.abmDepositos(accion, objDeposito);
		}
		public DataSet listadoDepositos(string cual)
		{
			return DatosObjDepositos.listadoDepositos(cual);
		}

        public List<Deposito> ObtenerDepositos()
        {

            return DatosObjDepositos.ObtenerDepositos();

        }

    }
}
