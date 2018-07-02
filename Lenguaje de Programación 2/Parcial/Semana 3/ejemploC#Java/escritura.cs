using System.IO;
using System;
public class escritura{
	public static void Main(){
		FileStream arch = new FileStream("./empleados.txt",FileMode.Append,FileAccess.Write);
		
		StreamWriter escritor = new StreamWriter(arch);
		
		persona p = new persona();
		
		System.Console.WriteLine("Ingrese el nombre: ");
		string nombre = System.Console.ReadLine();
		p.Nombre = nombre;
		
		System.Console.WriteLine("Ingrese la edad: ");
		string edad = System.Console.ReadLine();
		p.Edad = Int32.Parse(edad);
		
		escritor.WriteLine(p.Nombre);
		escritor.WriteLine(p.Edad);
		
		escritor.Close();
		arch.Close();
	}
	
}