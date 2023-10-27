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

		public int abmProductos(string accion, Producto objProducto)
		{
			return DatosObjProductos.abmProductos(accion, objProducto);
		}
		public DataSet listadoProductos(string cual)
		{
			return DatosObjProductos.listadoProductos(cual);
		}


    }
}
