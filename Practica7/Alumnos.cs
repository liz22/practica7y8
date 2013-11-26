using System;
using MySql.Data.MySqlClient;

namespace Practica8
{
	public class Alumnos:Mysql
	{
		public Alumnos ()
		{
		}
		public void mostrarTodos()
		{
			Console.Clear ();
			this.abrirConexion ();

			MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
			MySqlDataReader reader = myCommand.ExecuteReader();       
				while (reader.Read ()) {

					string id = reader["id"].ToString();
					//string codigo = reader["codigo"].ToString();
					string nombre = reader["nombre"].ToString();
					string telefono = reader["telefono"].ToString();
					string email = reader["email"].ToString();

					Console.WriteLine("ID:" + id + "\n"+
					                 // "Código:" + codigo + "\n"+
					                  "Nombre:" + nombre + "\n"+
					                  "Telefono:" + telefono + "\n"+
					                  "Email:" + email +"\n" );
				}

				reader.Close();
				reader = null;
				myCommand.Dispose();
				myCommand= null;
				this.cerrarConexion ();

		}
		public void insertarRegistroNuevo(string nombre, string codigo, string telefono, string email)
		{

			this.abrirConexion();
			string sql = "INSERT INTO `contactos`(`nombre`, `codigo`, `telefono`, `email`)" + 
				"VALUES ('" + nombre + "', '" + codigo + "','"+ telefono +"','" + email +"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();

			Console.WriteLine("Alumno Insertado con exito");
			Console.WriteLine ();
			Console.WriteLine("Código:" + codigo + "\n"+
			                  "Nombre:" + nombre + "\n"+
			                  "Telefono:" + telefono + "\n"+
			                  "Email:" + email +"\n" );


		}
		public void editarCodigoRegistro(string id, string nombre,string codigo, string telefono, string email)
		{
			this.abrirConexion();
			string sql = "UPDATE `contactos` SET `nombre`='"+nombre+"',`codigo`='"+codigo+"',`telefono`='"+telefono+"',`email`='"+email+"' WHERE id="+id+"";                       
			this.ejecutarComando(sql);
			this.cerrarConexion();


			Console.WriteLine("Alumno Modificado con exito");
			Console.WriteLine ();
			Console.WriteLine("Código:" + codigo + "\n"+
			                  "Nombre:" + nombre + "\n"+
			                  "Telefono:" + telefono + "\n"+
			                  "Email:" + email +"\n" );



		}
		public void eliminarRegistroPorId(string id)
		{
			this.abrirConexion();
			string sql = "DELETE FROM `contactos` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();

			Console.WriteLine("Alumno fue eliminado con exito");
			Console.WriteLine ();
			Console.WriteLine("Id:" +id);
		}
		private int ejecutarComando(string sql)
		{
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			if (afectadas == null)
				
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		private string querySelect()
		{
			return "SELECT * " +
				"FROM contactos";
		}

	}
}

