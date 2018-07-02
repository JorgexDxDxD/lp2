/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package AccesoDatos;

import Modelo.Pais;
import Modelo.Partido;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.util.ArrayList;

/**
 *
 * @author jorge
 */
public class PartidoDA {

    public ArrayList<Partido> listarPartidos() {
        try {
//            System.out.println("hola");
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://192.168.1.4/lp2?useSSL=false","jorge","20151521");
            CallableStatement sent = con.prepareCall("{call LISTAR_PARTIDOS()}"); 
            ResultSet rs = sent.executeQuery();
            
            ArrayList<Partido> lista = new  ArrayList<>();
            while(rs.next()){
                Partido p = new Partido();
                p.setEQUIPO_A(rs.getInt("EQUIPO_A"));
                p.setEQUIPO_B(rs.getInt("EQUIPO_B"));
                p.setGOLES_EQUIPO_A(rs.getInt("GOLES_EQUIPO_A"));
                p.setGOLES_EQUIPO_B(rs.getInt("GOLES_EQUIPO_B"));
                p.setJUGADO(rs.getBoolean("JUGADO"));
                lista.add(p);
            }            
            return lista;

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return null;
    }
    
    public void registrarPartido(Partido p){
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://192.168.1.4/lp2?useSSL=false","jorge","20151521");
            CallableStatement sent = con.prepareCall("{call REGISTRAR_PARTIDO(?,?,?,?)}"); 
            sent.setInt("SCORE_A", p.getGOLES_EQUIPO_A());
            sent.setInt("SCORE_B", p.getGOLES_EQUIPO_B());
            sent.setInt("EQ_A", p.getEQUIPO_A());
            sent.setInt("EQ_B", p.getEQUIPO_B());
            sent.execute();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        
    }
    
    public void eliminarResultado(Partido p){
        try {
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection("jdbc:mysql://192.168.1.4/lp2?useSSL=false","jorge","20151521");
            CallableStatement sent = con.prepareCall("{call ELIMINAR_RESULTADO_PARTIDO(?,?)}"); 
            sent.setInt("EQ_A", p.getEQUIPO_A());
            sent.setInt("EQ_B", p.getEQUIPO_B());
            sent.execute();            
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
    }
    
}
