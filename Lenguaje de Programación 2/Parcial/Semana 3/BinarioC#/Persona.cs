using System;
[Serializable]
public class Persona{
	private string nombre;
	private int edad;
	
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
}