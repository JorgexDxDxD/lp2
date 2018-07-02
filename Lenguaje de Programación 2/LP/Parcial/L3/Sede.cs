using System.Collections.Generic;
public class Sede{
	private string nombre;
	private string direccion;
	private List <Persona> medyAdmin;
	private List <Persona> ejecutivos;
	
	public Sede(string nombre,string direccion){
		this.nombre=nombre;
		this.direccion=direccion;
		medyAdmin= new List<Persona>();
		ejecutivos= new List<Persona>();
	}
	
	public void setNombre(string nombre){
		this.nombre=nombre;
	}
	
	public string getNombre(){
		return this.nombre;
	}
	
	public void setDireccion(string direccion){
		this.direccion=direccion;
	}
	public string getDireccion(){
		return this.direccion;
	}
	
	public void anadirPersonal(Persona p){
		if (p instanceof Ejecutivo)
			ejecutivos.Add(p);
		else 
			medyAdmin.Add(p);
	}
	
	public string mostrarMedyAdmin(){
		string rep = "";
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