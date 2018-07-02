namespace System;
using System.Collections.Generic;
public class Sede {
	private ind id;
	private string nombre;
	private string ciudad;
	private string direccion;
	private List <Cuenta> cuentas;
	
	public void mostrarClientes(){
		foreach (Cuenta c in this.cuentas){
			if (c.cli is Natural){
				Console.WriteLine(c.DNI + " "+ c.cli.nombre);
			}
			else {
				Console.WriteLine(c.RUC +" " +c.cli.razon);
			}
		}
	}
}