public class Medico : Persona , IConsultable{
	private Especialidad esp;
	private string nombre;
	private string ap;
	private string am;
	private int coleg;
	
	public Medico(double salario, TipoDedicacion t, int anexo, string sexo, int dni,
	int edad,string estadoCivil,string nombre,string ap,string am,int coleg, Especialidad esp){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.am=am;
		this.coleg=coleg;
		this.esp=esp;
	}
	
	public string consultarDatos(){
		return (nombre + " "+ap + " "+am + " "+esp.getNombre());
	}
}