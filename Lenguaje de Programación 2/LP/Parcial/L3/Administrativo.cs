public class Administrativo : Persona, IConsultable{
	private string nombre;
	private string ap;
	private string am;
	private string regimen;
	private string funcion;
	
	public Administrativo(double salario, TipoDedicacion t, int anexo, string sexo, int dni,
	int edad,string estadoCivil,string nombre,string ap,string am,string regimen,string funcion){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.am=am;
		this.regimen=regimen;
		this.funcion=funcion;
	}
	
	public string consultarDatos(){
		TipoDedicacion tipo = getT();
		return  (nombre + " "+ap + " "+am + " "+ tipo + " "+regimen);
	}
}