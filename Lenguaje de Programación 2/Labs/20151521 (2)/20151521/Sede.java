import java.util.List;
import java.util.ArrayList;
public class Sede{
	private String nombre;
	private String direccion;
	private ArrayList <Persona> medyAdmin;
	private ArrayList <Persona> ejecutivos;
	
	public Sede(String nombre,String direccion){
		this.nombre=nombre;
		this.direccion=direccion;
		medyAdmin= new ArrayList<Persona>();
		ejecutivos= new ArrayList<Persona>();
	}
	
	public void setNombre(String nombre){
		this.nombre=nombre;
	}
	
	public String getNombre(){
		return this.nombre;
	}
	
	public void setDireccion(String direccion){
		this.direccion=direccion;
	}
	public String getDireccion(){
		return this.direccion;
	}
	
	public void anadirPersonal(Persona p){
		if (p instanceof Ejecutivo)
			ejecutivos.add(p);
		else 
			medyAdmin.add(p);
	}
	
	public String mostrarMedyAdmin(){
		String rep = "";
		for (Persona p : this.medyAdmin){
			if (p instanceof Medico){
				rep = rep + ((Medico)p).consultarDatos();
			}
			else if (p instanceof Administrativo) 
				rep = rep +((Administrativo)p).consultarDatos();
		}
		return rep;
	}
	
}