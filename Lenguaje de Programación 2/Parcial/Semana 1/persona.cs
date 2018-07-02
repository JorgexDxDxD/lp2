public class persona{
	private string _nombre;
	private int _edad;
	
	public persona(string nombreRecibe, int edadRecibe){
		this._nombre = nombreRecibe;
		this._edad = edadRecibe;
	}
	
	public persona(string nombreRecibe){
		this._nombre = nombreRecibe;
	}
	
	public persona(){
	}
	
	public string Nombre{
		get{
			return _nombre;
		}
		set{
			_nombre = value;
		}
	}
	
	public int Edad{
		get{
			return _edad;
		}
		set{
			_edad = value;
		}
	}
	
	public void mostrarNombre(){
		System.Console.WriteLine(_nombre + " "+_edad);
	}
	
	~persona(){
		System.Console.WriteLine("Se esta destruyendo un objeto");
	}
}