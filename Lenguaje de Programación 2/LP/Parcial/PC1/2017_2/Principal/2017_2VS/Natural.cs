public class Natural :Cliente,IConsultable {
    private int dni;
    public string nombre;
    private string ap;
    private string am;
    private string sexo;
    private int edad;

    public Natural (int id, int dni, string nombre, string ap, string am):base(id)
    {
        this.dni = dni;
        this.nombre = nombre;
        this.ap = ap;
        this.am = am;
    }
    public int DNI {
        get
        {
            return dni;
        }
        set
        {
            dni = value;
        }
    }
    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }

    public string consultarDatos()
    {
        return (dni + " " + nombre + " " + ap + " " + am + " ");
    }
}