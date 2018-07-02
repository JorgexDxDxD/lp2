/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package experimentostiempo;

import java.util.Date;
import java.util.TimeZone;

/**
 *
 * @author jorge
 */
public class ExperimentosTiempo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Date fecha = new Date();
        System.out.println(fecha.toString().substring(4, 7));
    }
    
}
