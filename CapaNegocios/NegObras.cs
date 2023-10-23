using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class NegObras
    {

		AdministrarObras DatosObjObras = new AdministrarObras();

		public int abmObras(string accion, Obra objObras)
		{
			return DatosObjObras.abmObras(accion, objObras);
		}
		public DataSet listadoObras(string cual)
		{
			return DatosObjObras.listadoObras(cual);
		}

        public List<Obra> ObtenerObras()
        {

            return DatosObjObras.ObtenerObras();

        }

    }
}
