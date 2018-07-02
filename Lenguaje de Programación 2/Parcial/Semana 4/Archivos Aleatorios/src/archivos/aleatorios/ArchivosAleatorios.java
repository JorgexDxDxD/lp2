/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package archivos.aleatorios;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.RandomAccessFile;
class persona{
	public int edad;
	public String nombre;//+2
	public float CRAEST;
	
	public persona(int edad, float CRAEST, String nombre){
		this.edad = edad;
		this.CRAEST = CRAEST;
		if (nombre.length()<60){
			this.nombre = String.format("%-60s",nombre);
		}
		else{
			this.nombre = nombre.substring(0,60);
		}
		
	}
}
public class ArchivosAleatorios{
	public static void main(String[] args) throws Exception{
		RandomAccessFile arch = new RandomAccessFile("datos2.dat","rw");
		
		persona p1 = new persona(23,34.3f,"Miguel Gonzales");
		
		arch.writeUTF(p1.nombre);
		arch.writeInt(p1.edad);
		arch.writeFloat(p1.CRAEST);
		
		BufferedReader Entrada = new BufferedReader( new InputStreamReader(System.in));
		persona p2 = new persona(19,21.0f,"Karla Cordova");
                
                p2.nombre=Entrada.readLine();
                
		arch.writeUTF(p2.nombre);
		arch.writeInt(p2.edad);
		arch.writeFloat(p2.CRAEST);
		
		arch.seek(70);
		int tamanho = (int) arch.length();
		
		//for(int i=0;i<2;i++){
			String nombre = arch.readUTF();
			int edad = arch.readInt();
			float craest = arch.readFloat();
			System.out.println(nombre+" "+edad+" "+craest);
		//}
		
		arch.close();
	}
}