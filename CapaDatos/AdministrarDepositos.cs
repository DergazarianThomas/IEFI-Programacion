using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class AdministrarDepositos : DatosConexion
	{

		public int abmDepositos(string accion, Deposito objDeposito)
		{
			int resultado = -1;  // para controlar que se realize la operacion con exito
			string orden = string.Empty; // para guardad consulta sql
			if (accion == "Alta")
			{
				orden = $"insert into Depositos (IdDeposito, NombreDeposito, Direccion, IdObra) values ({objDeposito.IdDeposito},' {objDeposito.NombreDeposito}',' {objDeposito.Direccion}', {objDeposito.IdObra});";
			}
			

			if (accion == "Modificar")
				

				orden = $"update Depositos set NombreDeposito='{objDeposito.NombreDeposito}', Direccion='{objDeposito.Direccion}',  WHERE IdDeposito Like '%{objDeposito.IdDeposito}%';";


			if (accion == "Borrar")
				orden = "delete * from Depositos where IdDeposito =" + objDeposito.IdDeposito + ";";


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

		public DataSet listadoDepositos(string cual)
		{
			string orden = string.Empty;
			if (cual != "Todos")
				orden = "select * from Depositos where IdDeposito = " + int.Parse(cual) + ";";
			else
				orden = "select * from Depositos;";
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
				throw new Exception("Error al listar Depositos", e);
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
