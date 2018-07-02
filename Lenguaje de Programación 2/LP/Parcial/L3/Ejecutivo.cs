public class Ejecutivo : Persona{
	private string nombre;
	private string ap;
	private int pasaporte;
	private int ssn;
	private int dni;
	
	public Ejecutivo(double salario, TipoDedicacion t, int anexo,string sexo, int dni, int edad,string estadoCivil,int pasaporte, int ssn,string nombre,string ap){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.ssn = ssn;
		this.dni = ssn;
	}

}