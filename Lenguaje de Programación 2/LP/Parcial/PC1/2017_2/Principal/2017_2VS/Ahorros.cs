using System;
public class Ahorros : Cuenta, IConsultable {
	private double interesAnual;
	private double saldo;
	private DateTime fecha;
    public Ahorros(int idC, double interesAnual, double saldo) : base(idC)
    {
        this.interesAnual = interesAnual;
        this.saldo = saldo;
    }
    public string consultarDatos()
    {
        return (codigo.ToString() +" " + saldo.ToString());
    }
}