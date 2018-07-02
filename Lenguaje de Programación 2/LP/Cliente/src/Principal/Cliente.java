/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Principal;

import Interfaces.InterfazRemota;
import java.net.MalformedURLException;
import java.net.UnknownHostException;
import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author jorge
 */
public class Cliente {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args)  {
        // TODO code application logic here
        try {
            InterfazRemota ir = (InterfazRemota) java.rmi.Naming.lookup
                ("//"+java.net.InetAddress.getLocalHost().getHostAddress()+":1234/rmi");
            ir.listarAeropuertos();
            
        } catch (Exception e){
            e.printStackTrace();
        }
    }
    
}
