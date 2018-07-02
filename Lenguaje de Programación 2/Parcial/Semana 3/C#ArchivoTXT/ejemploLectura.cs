using System.IO;
public class ejemploLectura{
	public static void Main(){
		string ruta = "./texto.txt";
		
		FileStream fs = new FileStream(ruta,FileMode.Open,FileAccess.Read);
		
		StreamReader lector = new StreamReader(fs);
		
		while(true){
			string linea = lector.ReadLine();
			if (linea == null) break;
			System.Console.WriteLine(linea);
		}
		
		lector.Close();
		fs.Close();
	}
}