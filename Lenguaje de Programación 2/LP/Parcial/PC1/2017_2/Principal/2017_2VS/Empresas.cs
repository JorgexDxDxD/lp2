public class Empresas:Cliente,IConsultable {
    public int ruc;
    public string razon;
    private string actividad;

    public Empresas(int idC, int ruc, string razon): base(idC)
    {
        this.ruc = ruc;
        this.razon = razon;
    }
    public string consultarDatos()
    {
        return (ruc + " " + razon);
    }
    public int RUC
    {
        get
        {
            return ruc;
        }
        set
        {
            ruc = value;
        }
    }
    public string Razon
    {
        get
        {
            return razon;
        }
        set
        {
            razon = value;
        }
    }

}