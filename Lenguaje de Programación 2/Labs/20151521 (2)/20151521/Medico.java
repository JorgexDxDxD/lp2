public class Medico extends Persona implements IConsultable{
	private Especialidad esp;
	private String nombre;
	private String ap;
	private String am;
	private int coleg;
	
	public Medico(double salario, TipoDedicacion t, int anexo, String sexo, int dni,
	int edad,String estadoCivil,String nombre,String ap,String am,int coleg, Especialidad esp){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.am=am;
		this.coleg=coleg;
		this.esp=esp;
	}
	
	public String consultarDatos(){
		return (nombre + " "+ap + " "+am + " "+esp.getNombre());
	}
}