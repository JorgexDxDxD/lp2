public abstract class Cuenta{
	protected int codigo;
    public Cliente cli;
    public Tarjeta tar;

    public Cuenta (int codigo)
    {
        this.codigo = codigo;
    }

    public void asignarCliente (Cliente cli)
    {
        this.cli = cli;
    }

    public void asignarTarjeta (Tarjeta tar)
    {
        this.tar = tar;
    }
    public Cliente Cli
    {
        get
        {
            return cli;
        }
        set
        {
            cli = value;
        }
    }
    public Tarjeta Tar
    {
        get
        {
            return tar;
        }
        set
        {
            tar = value;
        }
    }
}