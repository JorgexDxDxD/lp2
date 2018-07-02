import java.io.FileWriter;
import java.io.BufferedReader;
import java.io.InputStreamReader;
public class ejemploEscritura{
	public static void main(String[] args) throws Exception{
		String ruta = "./texto2.txt";
		FileWriter archivo = new FileWriter(ruta);
		
		BufferedReader Entrada = new BufferedReader( new InputStreamReader(System.in));

		while(true){
			String linea = Entrada.readLine();
			if (linea == null) break;
			archivo.write(linea + "\n");
		}
		
		archivo.close();
	}
}