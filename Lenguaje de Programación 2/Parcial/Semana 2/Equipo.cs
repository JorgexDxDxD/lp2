using System.Collections.Generic;
public class Equipo{
	//private Equipu equipu;
	private string _nombre;
	private string _interes;
	private List<Miembro> _miembros;
	
	public Equipo(){
		_miembros = new List<Miembro>();
	}
	
	public List<Miembro> miembros{
		set{
			_miembros = value;
		}
		get{
			return _miembros;
		}
	}
	
	public string nombre{
		get{
			return _nombre;
		}
		set{
			_nombre = value;
		}
	}
	
	public string interes{
		get{
			return _interes;
		}
		set{
			_interes = value;
		}
	}
	
	public void agregarMiembro(Miembro m){
		_miembros.Add(m);
	}
}