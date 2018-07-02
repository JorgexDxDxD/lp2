public class Especialidad{
	private String nombre;
	private String clasif;
	
	public Especialidad (String nombre,String clasif){
		this.nombre=nombre;
		this.clasif=clasif;
	}
	
	public void setNombre(String nombre){
		this.nombre=nombre;
	}
	
	public String getNombre(){
		return this.nombre;
	}
	
	public void setClasif(String clasif){
		this.clasif=clasif;
	}
	public String getClasif(){
		return this.clasif;
	}
	
	
}