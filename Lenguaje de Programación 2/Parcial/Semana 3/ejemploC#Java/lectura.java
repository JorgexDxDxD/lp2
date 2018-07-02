import java.io.FileReader;
import java.io.BufferedReader;
public class lectura{
	public static void main(String[] args) throws Exception{
		FileReader fr = new FileReader("./empleados.txt");
		
		BufferedReader br = new BufferedReader(fr);
		
		while(true){
			String nombre = br.readLine();
			if (nombre == null) break;
			String edad = br.readLine();
			persona p = new persona();
			p.setNombre(nombre);
			p.setEdad(Integer.parseInt(edad));
			System.out.println(p.getNombre() +" "+p.getEdad());
		}
		
		fr.close();
	}
}