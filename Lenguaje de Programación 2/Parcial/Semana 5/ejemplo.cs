using System.Windows.Forms;
class MiVentana : Form {
	public MiVentana(){
		this.Visible = true;
		this.Size = new System.Drawing.Size(500,500);
		this.Text = "Titulo del formulario";
		//this.WindowState = FormWindowState.Maximized;
		
		//Colocando una etiqueta
		Label etiqueta = new Label();
		etiqueta.Text = "Este es un mensaje:";
		//etiqueta.Size = new System.Drawing.Size(10,10);
		etiqueta.AutoSize = true;
		etiqueta.Location = new System.Drawing.Point(10,10);
		this.Controls.Add(etiqueta);
		
		//Agregando un caja de texto
		TextBox cajaDeTexto = new TextBox();
		cajaDeTexto.Size = new System.Drawing.Size(100 , 10);
		cajaDeTexto.Location = new System.Drawing.Point(10 + etiqueta.Width + 10 , 10);
		this.Controls.Add(cajaDeTexto);
		
		//Agregando un boton
		Button boton = new Button();
		boton.Text = "Presione aqui";
		boton.Size = new System.Drawing.Size(100 , 30);
		boton.Location = new System.Drawing.Point(10, 30);
		this.Controls.Add(boton);
		
	}
}
public class ejemplo{
	public static void Main(){
		MiVentana mv = new MiVentana();
		Application.Run(mv);
	}
}