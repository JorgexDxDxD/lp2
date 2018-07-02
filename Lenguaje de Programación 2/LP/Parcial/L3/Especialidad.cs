public class Especialidad{
	private string nombre;
	private string clasif;
	
	public Especialidad (string nombre,string clasif){
		this.nombre=nombre;
		this.clasif=clasif;
	}
	
	public void setNombre(string nombre){
		this.nombre=nombre;
	}
	
	public string getNombre(){
		return this.nombre;
	}
	
	public void setClasif(string clasif){
		this.clasif=clasif;
	}
	public string getClasif(){
		return this.clasif;
	}
	
	
}