﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
	public class DatosConexion
	{
		protected OleDbConnection conexion;
		//protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\VS22\IEFI-programacion\IEFI-Programacion.accdb";
		protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ramiro\source\repos\IEFI-programacion\IEFI-Programacion.accdb";
        //protected string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = F:\VS22\IEFI-Programacion\IEFI-Programacion.accdb";
        public DatosConexion()
		{
			conexion = new OleDbConnection(cadenaConexion);
		}
		public void Abrirconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Broken || conexion.State ==
				ConnectionState.Closed)
					conexion.Open();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de abrir la conexión", e);
			}
		}

		public void Cerrarconexion()
		{
			try
			{
				if (conexion.State == ConnectionState.Open)
					conexion.Close();
			}
			catch (Exception e)
			{
				throw new Exception("Error al tratar de cerrar la conexión", e);
			}
		}
	}
}
