using System;

namespace Practica8
{
	public class Programa
	{
		public Programa ()
		{
		}

		Alumnos alumnos = new Alumnos();

		public void mostrarMenu()
		{
			Console.Clear ();
			Console.WriteLine("Menu Principal:");
			Console.WriteLine("1.-Mostrar todos");
			Console.WriteLine("2.-Agregar Nuevo Registro");
			Console.WriteLine("3.-Editar Regustro");
			Console.WriteLine("4.-Eliminar Regitros");
			Console.WriteLine("5.-Salir");

			string opc;

			opc = Console.ReadLine();
			switch (opc) 
			{
				case "1":
						alumnos.mostrarTodos ();
						mostrarMenu ();
						break;
				case "2":
						solicitarDatos ();
						mostrarMenu ();
						break;
				case "3":
						modificarPersona ();
						mostrarMenu ();
						break;
	
				case "4":
						System.Environment.Exit (-1);
						break;
				}


		}
		public void modificarPersona()
		{
			Console.Clear ();
			Console.WriteLine("Modificar Registro");
			Console.WriteLine("Dame el id:");
			string id = Console.ReadLine();
			Console.WriteLine("Dame el Nombre:");
			string nombre = Console.ReadLine();
			Console.WriteLine("Dame el Codigo:");
			string codigo = Console.ReadLine();
			Console.WriteLine("Dame el Telefono:");
			string telefono = Console.ReadLine();
			Console.WriteLine("Dame el email:");
			string email = Console.ReadLine();	
			Console.Clear();
			alumnos.editarCodigoRegistro(id,nombre,codigo,telefono,email);
			Console.ReadLine ();

		}
		public void solicitarDatos()
		{

			Console.Clear ();
			Console.WriteLine("Dame el Nombre:");
			string nombre = Console.ReadLine();
			Console.WriteLine("Dame el Codigo:");
			string codigo = Console.ReadLine();
			Console.WriteLine("Dame el Telefono:");
			string telefono = Console.ReadLine();
			Console.WriteLine("Dame el email:");
			string email = Console.ReadLine();	
			Console.Clear();
			alumnos.insertarRegistroNuevo(nombre,codigo,telefono,email);
			Console.ReadLine ();


		}
		public void elminarRegistro()
		{
			Console.Clear ();
			Console.WriteLine ("Modificar Registro");
			Console.WriteLine ("Dame el id:");
			string id = Console.ReadLine ();
			alumnos.eliminarRegistroPorId (id);
			Console.ReadLine ();
		}
	}
}

