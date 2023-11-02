using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class AdministrarProductos : DatosConexion
	{

		public int abmProductos(string accion, Producto objProducto)
		{
			int resultado = -1;  
			string orden = string.Empty; 
			if (accion == "Alta")
			{
				orden = $"insert into Productos (Codigo, NombreProducto, Descripcion, Estado, Cantidad, IdDeposito) values ({objProducto.Codigo}, '{objProducto.NombreProducto}', '{objProducto.Descripcion} ',{objProducto.Estado} , {objProducto.Cantidad}, {objProducto.IdDeposito});";
			}
			

			if (accion == "Modificar")
				

				orden = $"update Productos set NombreProducto='{objProducto.NombreProducto} ', Descripcion=' {objProducto.Descripcion}', Estado={objProducto.Estado}, Cantidad={objProducto.Cantidad}, IdDeposito={objProducto.IdDeposito} WHERE Codigo Like '%{objProducto.Codigo}%';";


			if (accion == "Borrar")
				orden = "delete * from Productos where Codigo =" + objProducto.Codigo + ";";


			OleDbCommand cmd = new OleDbCommand(orden, conexion);
			try
			{
				Abrirconexion();
				resultado = cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				throw new Exception($"Error de la accion {accion}", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return resultado;
		}

		public DataSet listadoProductos(string cual)
		{
			string orden = string.Empty;
			if (cual != "Todos")
				orden = "select p.Codigo, p.NombreProducto, p.Descripcion, p.Estado, p.Cantidad, d.NombreDeposito from Productos p, Depositos d where p.IdDeposito = " + int.Parse(cual) + " and p.IdDeposito = d.IdDeposito;";
			else
				orden = "select * from Productos;";
			OleDbCommand cmd = new OleDbCommand(orden, conexion);
			DataSet ds = new DataSet();
			OleDbDataAdapter da = new OleDbDataAdapter();
			try
			{
				Abrirconexion();
				cmd.ExecuteNonQuery();
				da.SelectCommand = cmd;
				da.Fill(ds);
			}
			catch (Exception e)
			{
				throw new Exception("Error al listar Productos", e);
			}
			finally
			{
				Cerrarconexion();
				cmd.Dispose();
			}
			return ds;
		}



    }
}
