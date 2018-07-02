/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cliente_java_s_c3;

/**
 *
 * @author jorge
 */
public class Cliente_JAVA_S_C3 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        cliente_java_s_c3.SumarWS obj = new cliente_java_s_c3.SumarWS();
        cliente_java_s_c3.SumarWSSoap port = obj.getSumarWSSoap();
        System.out.println(port.sumar(3,4));
    }
    
}
