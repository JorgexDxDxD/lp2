using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServidorC3
{
    /// <summary>
    /// Summary description for SumarWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SumarWS : System.Web.Services.WebService
    {

        [WebMethod] public double sumar(double a, double b) { return a + b; }
        [WebMethod] public double restar(double a, double b) { return a - b; }
        [WebMethod] public double multiplicar(double a, double b) { return a * b; }
        [WebMethod] public double dividir(double a, double b) { return a / b; }
        [WebMethod] public String saludar(String nombre) { return "Hola " + nombre; }
    }
}
