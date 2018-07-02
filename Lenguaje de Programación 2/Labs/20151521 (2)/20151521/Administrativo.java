public class Administrativo extends Persona implements IConsultable{
	private String nombre;
	private String ap;
	private String am;
	private String regimen;
	private String funcion;
	
	public Administrativo(double salario, TipoDedicacion t, int anexo, String sexo, int dni,
	int edad,String estadoCivil,String nombre,String ap,String am,String regimen,String funcion){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.am=am;
		this.regimen=regimen;
		this.funcion=funcion;
	}
	
	public String consultarDatos(){
		TipoDedicacion tipo = getT();
		return  (nombre + " "+ap + " "+am + " "+ tipo + " "+regimen);
	}
}