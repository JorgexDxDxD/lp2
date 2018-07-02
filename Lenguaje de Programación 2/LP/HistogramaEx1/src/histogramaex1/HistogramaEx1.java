/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package histogramaex1;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

/**
 *
 * @author jorge
 */
public class HistogramaEx1 {

    /**
     * @param args the command line arguments
     * @throws java.lang.Exception
     */
    public static void main(String[] args) throws Exception {
        // TODO code application logic here
        Class.forName("com.mysql.jdbc.Driver");
        Connection con = DriverManager.getConnection("jdbc:mysql://localhost/lp2?useSSL=false", "root","jorgito2206");
        
        String query = "SELECT * FROM MEDICAMENTO";
        Statement sentence = con.createStatement();
        ResultSet rs =sentence.executeQuery(query);
        while(rs.next()){
            System.out.println(rs.getString("NOMBRE"));
            System.out.println(rs.getString("PRESENTACION"));
        }
        con.close();
        
        
        
        
    }
    
}
