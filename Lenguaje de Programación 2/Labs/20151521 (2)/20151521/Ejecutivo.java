public class Ejecutivo extends Persona{
	private String nombre;
	private String ap;
	private int pasaporte;
	private int ssn;
	private int dni;
	
	public Ejecutivo(double salario, TipoDedicacion t, int anexo,String sexo, int dni, int edad,String estadoCivil,int pasaporte, int ssn,String nombre,String ap){
		super( salario,  t,  anexo,sexo,  dni,  edad,estadoCivil);
		this.nombre=nombre;
		this.ap=ap;
		this.ssn = ssn;
		this.dni = ssn;
	}

}