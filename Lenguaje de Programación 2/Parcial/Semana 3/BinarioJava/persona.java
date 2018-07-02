import java.io.Serializable;

public class persona implements Serializable{
	private String nombre;
	private int edad;
	
	public void setNombre(String nombre){
		this.nombre = nombre;
	}
	
	public String getNombre(){
		return nombre;
	}
	
	public void setEdad(int edad){
		this.edad = edad;
	}
	
	public int getEdad(){
		return edad;
	}
}