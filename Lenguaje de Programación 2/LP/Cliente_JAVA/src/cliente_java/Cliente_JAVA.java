/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cliente_java;

import java.util.List;

/**
 *
 * @author jorge
 */
public class Cliente_JAVA {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        cliente_java.PartidosWS_Service servicio = new cliente_java.PartidosWS_Service();
        cliente_java.PartidosWS port = servicio.getPartidosWSPort();
        List<Pais> a = port.listarPaises();
        for (int i=0;i< a.size();i++){
            System.out.println(a.get(i).nombre + "  "+  a.get(i).grupo);
            System.out.println(i);
        }
    }
    
}
