using System;
public class Miembro{
	private int codigo;
	private string _nombre;
	private DateTime fechaNac;
	private string direccion;
	private string email;
	private char sexo;
	
	public string nombre{
		set{
			this._nombre = value;
		}
		get{
			return _nombre;
		}
	}
}