import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.FileReader;
public class ejemploLectura{
	public static void main(String[] args) throws Exception{
		String ruta = "./texto2.txt";
		
		FileReader archivo = new FileReader(ruta);
		
		BufferedReader lector = new BufferedReader(archivo);

		while(true){
			String linea = lector.readLine();
			if (linea == null) break;
			System.out.println(linea);
		}
		
		archivo.close();
	}
}