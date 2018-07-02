package Persona;
public class persona{
	private String nombre;
	private int edad;
	
	public persona(String nombreRecibe, int edadRecibe){
		this.nombre = nombreRecibe;
		this.edad = edadRecibe;
	}
	
	public persona(String nombreRecibe){
		this.nombre = nombreRecibe;
	}
	
	public persona(){
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public void setNombre(String nombreRecibe){
		this.nombre = nombreRecibe;
	}
	
	public int getEdad(){
		return edad;
	}
	
	public void setEdad(int edadRecibe){
		this.edad = edadRecibe;
	}
	
	public void mostrarNombre(){
		System.out.println(this.nombre + " " + this.edad);
	}
}