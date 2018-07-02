public abstract class Persona{
	private int codigo;
	private static int contador =1;
	private double salario;
	private TipoDedicacion t;
	private int anexo;
	
	private String sexo;
	private int dni;
	private int edad;
	private String estadoCivil;
	
	public Persona (double salario, TipoDedicacion t, int anexo, String sexo, int dni, int edad,String estadoCivil){
		this.codigo = contador ;
		this.contador ++;
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