import java.util.ArrayList;
import java.io.ObjectOutputStream;
import java.io.ObjectInputStream;
import java.io.BufferedOutputStream;
import java.io.BufferedInputStream;
import java.io.FileOutputStream;
import java.io.FileInputStream;
public class principal{
	public static void main(String[] args) throws Exception{
		ArrayList<persona> personas = new ArrayList<persona>();
		
		persona p1 = new persona();
		p1.setNombre("Miguel Guanira");
		p1.setEdad(40);
		
		persona p2 = new persona();
		p2.setNombre("Alejandro Bello");
		p2.setEdad(35);
		
		personas.add(p1);
		personas.add(p2);
		
		//Crear archivo Binario
		
		ObjectOutputStream archivo = 
		new ObjectOutputStream(new BufferedOutputStream (new FileOutputStream("./archivoBinJava.dat")));
		
		for (int i=0;i<personas.size();i++){
			archivo.writeObject(personas.get(i));
		}
		
		archivo.close();
		
		ObjectInputStream archivoLect = 
		new ObjectInputStream(new BufferedInputStream (new FileInputStream("C:/LP2/archivoBinJava.dat")));
		
		while(true){
			try{
				persona per = (persona) archivoLect.readObject();
				System.out.println(per.getNombre() + " " + per.getEdad());
			}catch(Exception e){
				break;
			}
		}
		archivoLect.close();
	}
}