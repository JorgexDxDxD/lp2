using System;
public class Alumno : Miembro, Consultable{
	private int codAlumno;
	private float CRAEST;
	
	public string consultarDatos(){
		return codAlumno.ToString() +
		" "+CRAEST.ToString();
	}
}