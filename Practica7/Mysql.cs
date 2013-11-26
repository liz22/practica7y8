using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Practica8
{
	public class Mysql
	{
		protected  MySqlConnection myConnection;
		public Mysql ()
		{
		}

		protected void abrirConexion(){
			string connectionString =
					"Server=localhost;" +
					"Database=alumnos;" +
					"User ID=root;" +
					"Password=123456789;" +
					"Pooling=false";
			this.myConnection = new MySqlConnection(connectionString);
			this.myConnection.Open ();


		}
		protected void cerrarConexion()
		{
			this.myConnection.Close ();
			this.myConnection= null;

		}


	}
}

