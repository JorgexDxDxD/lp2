using System.IO;
using System;
class persona{
	public const int tamanhoCadena = 60;
	private string nombre;
	// 60 bytes + 1
	private int edad;
	private float _CRAEST;
	
	public persona(){
		
	}
	
	public persona(string nombre, int edad, float _CRAEST){
		this.edad = edad;
		this._CRAEST = _CRAEST;
		if (nombre.Length < 60){
			this.nombre = nombre.PadRight(60);
		}
		else{
			this.nombre = nombre.Substring(0,60);
		}
	}
	
	public string Nombre{
		set{
			nombre = value;
		}
		get{
			return nombre;
		}
	}
	
	public int Edad{
		set{
			edad = value;
		}
		get{
			return edad;
		}
	}
	
	public float CRAEST{
		set{
			_CRAEST = value;
		}
		get{
			return _CRAEST;
		}
	}
}

public class ejemplo{
	public static void Main(string[] args){
		FileStream arch = new FileStream("C:/LP2/datos.dat",FileMode.Create, FileAccess.Write);
		
		BinaryWriter escritor = new BinaryWriter(arch);
		
		persona p1 = new persona("Karla Cordova",23,76.5f);
		
		escritor.Write(p1.Nombre);
		escritor.Write(p1.Edad);
		escritor.Write(p1.CRAEST);
		
		persona p2 = new persona("Hugo Caceres",18,81.4f);
		
		escritor.Write(p2.Nombre);
		escritor.Write(p2.Edad);
		escritor.Write(p2.CRAEST);
		
		escritor.Close();
		arch.Close();
		
		FileStream arch2 = new FileStream("C:/LP2/datos.dat",FileMode.Open, FileAccess.ReadWrite);
		
		BinaryReader lector = new BinaryReader(arch2);
		BinaryWriter escritor2 = new BinaryWriter(arch2);
		
		//for (int i=1;i<=2;i++){	
		//	System.Console.WriteLine(lector.ReadString().Trim());
		//	System.Console.WriteLine(lector.ReadInt32());
		//	System.Console.WriteLine(lector.ReadSingle());
		//}
		
		int tamanhoRegistro = 61 + sizeof(int) + sizeof(float);
		
		System.Console.WriteLine(lector.ReadString().Trim());
		System.Console.WriteLine(lector.ReadInt32());
		System.Console.WriteLine(lector.ReadSingle());
		
		
		int rpta;
		do{
			System.Console.WriteLine("1. Listar Registros");
			System.Console.WriteLine("2. Modificar un Registro");
			System.Console.WriteLine("0. Salir");
			System.Console.Write("Ingrese la instrucción: ");
			rpta = Convert.ToInt32(System.Console.ReadLine());
			switch(rpta){
				case 1:
				arch2.Position = 0;
				int cant = (int)arch2.Length /tamanhoRegistro;
				for(int j=0;j<cant;j++){
					System.Console.WriteLine(lector.ReadString().Trim());
					System.Console.WriteLine(lector.ReadInt32());
					System.Console.WriteLine(lector.ReadSingle());
				}
				break;
				case 2:
				System.Console.WriteLine("Ingrese el registro a modificar: ");
				int reg = Convert.ToInt32(System.Console.ReadLine());
				arch2.Position = reg * tamanhoRegistro;
				
				System.Console.WriteLine("Ingrese el nombre: ");
				string n = System.Console.ReadLine();
				System.Console.WriteLine("Ingrese la edad: ");
				int e = Convert.ToInt32(Console.ReadLine());
				System.Console.WriteLine("Ingrese el CRAEST: ");
				float c = Convert.ToSingle(Console.ReadLine());
				
				persona p3 = new persona(n,e,c);
				
				escritor2.Write(p3.Nombre);
				escritor2.Write(p3.Edad);
				escritor2.Write(p3.CRAEST);
				
				break;
			}
		}while(rpta!=0);
		lector.Close();
		escritor2.Close();
		arch2.Close();
	}
}