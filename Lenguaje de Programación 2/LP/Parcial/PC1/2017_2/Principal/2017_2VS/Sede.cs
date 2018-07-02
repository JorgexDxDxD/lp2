
using System.Collections.Generic;
public class Sede
{
    private int id;
    private string nombre;
    private string ciudad;
    private string direccion;
    private List<Cuenta> cuentas;
    
    public Sede (int vId, string vNombre, string vC, string vDir)
    {
        cuentas = new List<Cuenta>();
        id = vId;
        nombre = vNombre;
        ciudad = vC;
        direccion = vDir;
    }

    public void anadirCuenta(Cuenta c)
    {
        cuentas.Add(c);
    }
    public void mostrarClientes()
    {
        foreach (Cuenta c in this.cuentas)
        {
            if (c.Cli is Natural)
            {
                    
                System.Console.WriteLine(((Natural)c.Cli).DNI + " " + ((Natural)c.Cli).Nombre);
            }
            else
            {
                System.Console.WriteLine(((Empresas)c.Cli).RUC + " " + ((Empresas)c.Cli).Razon);
            }
        }
    }
}

