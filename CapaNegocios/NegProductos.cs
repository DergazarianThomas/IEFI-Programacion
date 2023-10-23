using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
	public class NegProductos
	{
		AdministrarProductos DatosObjProductos = new AdministrarProductos();

		public int abmCelulares(string accion, Producto objCelular)
		{
			return DatosObjProductos.abmProductos(accion, objCelular);
		}
		public DataSet listadoCelulares(string cual)
		{
			return DatosObjProductos.listadoProductos(cual);
		}


    }
}
