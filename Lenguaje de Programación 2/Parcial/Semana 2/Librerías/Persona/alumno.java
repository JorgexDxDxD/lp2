package Persona;
import Persona.Interfaz.*;
public class alumno extends persona implements IObtenerNota{
	private double CRAEST;
	private int semestre;
	
	public alumno(String nombreRecibe, int edadRecibe, double CRAEST, int semestre){
		super(nombreRecibe, edadRecibe);
		this.CRAEST = CRAEST;
		this.semestre = semestre;
	}
	
	@Override
	public void mostrarNombre(){
		System.out.println(this.getNombre() + " " + this.getEdad() + " " + this.CRAEST + " " + this.semestre);
	}
	
	public String obtenerNota(){
		//return String.format("%3.2f", CRAEST);
		return Double.toString(CRAEST);
	}
	
	public void finalize(){
		System.out.println("El objeto se esta destruyendo");
	}
}