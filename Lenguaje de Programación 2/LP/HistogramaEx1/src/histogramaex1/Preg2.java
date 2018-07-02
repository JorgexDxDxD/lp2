/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package histogramaex1;

import java.io.BufferedReader;
import java.io.FileReader;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;

/**
 *
 * @author jorge
 */
public class Preg2 {
    
    public static void main(String[] args) throws Exception {
        // TODO code application logic here
        
        String ruta = "./especialidades.txt";
        FileReader arch = new FileReader (ruta);
        BufferedReader entrada = new BufferedReader(arch);

        Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection("jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151521?useSSL=false", "a20151521","QiDSz7");
        System.out.println("hola");
        CallableStatement cSent = con.prepareCall("{call REGISTRAR_ESPECIALIDAD(?,?)}");
                
        while(true){
            String nombre;
            nombre = entrada.readLine();
            if (nombre == null) break;
            String clasif = entrada.readLine();
            
            cSent.setString("_NOMBRE", nombre);
            cSent.setString("_CLASIFICACION", clasif);
            cSent.execute();
        
        }
        
    }
}
