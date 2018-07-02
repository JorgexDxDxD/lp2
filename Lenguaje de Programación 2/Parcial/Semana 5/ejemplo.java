import javax.swing.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.Container;
import java.awt.FlowLayout;
class MiVentana extends JFrame{
	public MiVentana(){
		addWindowListener(new WindowAdapter(){
			public void windowClosing(WindowEvent we){
				dispose();
				System.exit(0);
			}
		});

		//Creando una etiqueta
		JLabel etiqueta = new JLabel("Ingrese un nombre: ");

		//Creando una caja de texto
		JTextField cajaTexto = new JTextField(20);

		//Creando un botón
		JButton boton = new JButton();
		boton.setText("OK");

		Container cp = this.getContentPane();
		cp.setLayout(new FlowLayout());
		cp.add(etiqueta);
		cp.add(cajaTexto);
		cp.add(boton);
	}
}

public class ejemplo{
	public static void main(String[] args){
		MiVentana mv = new MiVentana();
		mv.setVisible(true);
		mv.setSize(300,300);
	}
}