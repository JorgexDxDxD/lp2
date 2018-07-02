using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
public class Principal{
	public static void Main(){
		List<Persona> personas = new List<Persona>();
		Persona p1 = new Persona();
		p1.Nombre = "Miguel Guanira";
		p1.Edad = 50;
		Persona p2 = new Persona();
		p2.Nombre = "Alejandro Bello";
		p2.Edad = 60;
		
		personas.Add(p1);
		personas.Add(p2);
		
		
		//Escritura del Archivo Binario
		FileStream archivo = new FileStream("./datos.dat", FileMode.Create, FileAccess.Write);
		
		BinaryFormatter formateador = new BinaryFormatter();
		
		foreach ( Persona pe in personas ){
			formateador.Serialize(archivo, pe);
		}
		
		archivo.Close();
		
		//Lectura del Archivo Binario
		FileStream archivoLect = new FileStream("C:/LP2/datos.dat", FileMode.Open, FileAccess.Read);
		
		while(true){
			try{
				Persona per = (Persona) formateador.Deserialize(archivoLect);
				System.Console.WriteLine(per.Nombre +" "+ per.Edad);
			}catch(Exception e){
				break;
			};
		}
		archivoLect.Close();
	}
}