using System;
public class Credito : Cuenta, IConsultable {
	private double montoMax;
	private double credDisp;
	private double interes;
	private DateTime fecha;
    public Credito(int idC, double montoMax, double credDisp, double interes) : base(idC)
    {
        this.montoMax = montoMax;
        this.credDisp = credDisp;
        this.interes = interes;
    }
    public string consultarDatos()
    {
        return (codigo.ToString() + " " + montoMax.ToString() + " "+credDisp.ToString());
    }
}