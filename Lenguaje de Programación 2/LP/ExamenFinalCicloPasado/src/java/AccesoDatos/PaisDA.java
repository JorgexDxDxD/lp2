/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Pais;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

/**
 *
 * @author jorge
 */
public class PaisDA {
    public ArrayList<Pais> listarPaises(){
        try {
//            System.out.println("hola");
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://192.168.1.4/lp2?useSSL=false","jorge","20151521");
            CallableStatement sent = con.prepareCall("{call LISTAR_PAISES()}"); 
            ResultSet rs = sent.executeQuery();
            
            ArrayList<Pais> lista = new  ArrayList<>();
            while(rs.next()){
                Pais p = new Pais();
                p.setID_PAIS_CLASIFICADO(rs.getInt("ID_PAIS_CLASIFICADO"));
                p.setNOMBRE(rs.getString("NOMBRE"));
                p.setGRUPO(rs.getString("GRUPO"));
                p.setCATEGORIA_SORTEO(rs.getInt("CATEGORIA_SORTEO"));
                lista.add(p);
            }            
            return lista;

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
}
