using System.Collections.Generic;
public class Equipu{
	private List<Equipo> _equipos;
	private List<Miembro> _ejecutivos;
	
	public Equipu(){
		_equipos = new List<Equipo>();
		_ejecutivos = new List<Miembro>();
	}
	
	public List<Miembro> Ejecutivos{
		set{
			_ejecutivos = value;
		}
		get{
			return _ejecutivos;
		}
	}
	
	public List<Equipo> Equipos{
		set{
			_equipos = value;
		}
		get{
			return _equipos;
		}
	}
	
	public void agregarEquipo(Equipo E){
		_equipos.Add(E);
	}
	
	public void agregarEjecutivos(Miembro m)
	{
		_ejecutivos.Add(m);
	}
	
	public string consultarEquipo(int i){
		string cadena = "";
		foreach(Miembro m in this._equipos[i].miembros){
			if (m is Alumno){
				cadena = cadena + ((Alumno)m).consultarDatos() + "\n";
			}
			if(m is Profesor){
				cadena = cadena + ((Profesor)m).consultarDatos() + "\n";
			}
		}
		return cadena;
	}
}