using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class AdministrarObras : DatosConexion
	{

		public int abmObras(string accion, Obra objObra)
		{
			int resultado = -1;  // para controlar que se realize la operacion con exito
			string orden = string.Empty; // para guardad consulta sql
			if (accion == "Alta")
			{
				orden = $"insert into Obras (IdObra, NombreObra, Direccion) values ({objObra.IdObra}, '{objObra.NombreObra}','{objObra.Direccion}' );";
			}

			if (accion == "Modificar")

				orden = $"update Obras set NombreObra='{objObra.NombreObra}', Direccion='{objObra.Direccion}' WHERE IdObra Like '%{objObra.IdObra}%';";


			if (accion == "Borrar")
				orden = "delete * from Obras where IdObra =" + objObra.IdObra + ";";


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

		public DataSet listadoObras(string cual)
		{
			string orden = string.Empty;
			if (cual != "Todos")
				orden = "select * from Obras where IdObras = " + int.Parse(cual) + ";";
			else
				orden = "select * from Obras;";
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
				throw new Exception("Error al listar Obras", e);
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
