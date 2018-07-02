using System.IO;
public class ejemploEscritura{
	public static void Main(){
		string ruta = "./texto.txt";
		FileStream fs = new FileStream(ruta,FileMode.Create,FileAccess.Write);
		
		StreamWriter escritor = new StreamWriter(fs);
		
		while(true){
			string linea = System.Console.ReadLine();
			if (linea == null) break;
		    escritor.WriteLine(linea);
		}
		
		escritor.Close();
		fs.Close();
	}
}