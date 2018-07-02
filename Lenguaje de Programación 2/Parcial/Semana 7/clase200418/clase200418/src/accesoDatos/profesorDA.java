package accesoDatos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;
import modelo.profesor;

public class profesorDA {
    
    public void registrar(profesor p){
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection
            ("jdbc:mysql://127.0.0.1/lp2", "root", "123456");
            
            //Empleando - Statement - Opción 2
            String sql = "INSERT INTO PROFESOR (NOMBRE,APELLIDO) VALUES(?,?);";
            PreparedStatement sentencia = con.prepareStatement(sql);
            sentencia.setString(1,p.getNombre());
            sentencia.setString(2,p.getApellido());
            sentencia.executeUpdate();
            
            //Empleando - Statement - Opción 1
            //Statement sentencia = con.createStatement();
            //String sql = "INSERT INTO PROFESOR (NOMBRE,APELLIDO) VALUES "
            //        + "('"+p.getNombre()+"','"+p.getApellido()+"');";
            //sentencia.executeUpdate(sql);
            System.out.println("Registro realizado");
            con.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }
    
    public ArrayList<profesor> listarProfesores(){
        ArrayList<profesor> lista = new ArrayList<profesor>();
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection
            ("jdbc:mysql://127.0.0.1/lp2", "root", "123456");
            //Creación del Statement
            Statement sentencia = con.createStatement();
            String sql = "SELECT * from PROFESOR;";
            ResultSet rs = sentencia.executeQuery(sql);
            while(rs.next()){
                profesor p = new profesor();
                p.setId_profesor(rs.getInt("ID_PROFESOR"));
                p.setNombre(rs.getString("NOMBRE"));
                p.setApellido(rs.getString("APELLIDO"));
                lista.add(p);
            }
            con.close();
            
        }catch(Exception e){
            
        }
        return lista;
    }
}
