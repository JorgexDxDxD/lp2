public abstract class Persona{
	private int codigo;
	private double salario;
	private TipoDedicacion t;
	private int anexo;
	
	private string sexo;
	private int dni;
	private int edad;
	private string estadoCivil;
	
	public Persona (double salario, TipoDedicacion t, int anexo, string sexo, int dni, int edad,string estadoCivil){
		this.salario = salario;
		this.t=t;
		this.anexo=anexo;
	}
	public void setT(TipoDedicacion t){
		this.t=t;
	}
	
	public TipoDedicacion getT(){
		return this.t;
	}
}