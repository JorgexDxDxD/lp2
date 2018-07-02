public class Profesor : Miembro, Consultable{
	private int codProfesor;
	private estadoProf estado;
	
	public Profesor(int codProfesor, string nombre, estadoProf estado){
		this.codProfesor = codProfesor;
		this.nombre = nombre;
		this.estado = estado;
	}
	
	public string consultarDatos(){
		return codProfesor.ToString() + " " + nombre + " " + estado;
	}
}