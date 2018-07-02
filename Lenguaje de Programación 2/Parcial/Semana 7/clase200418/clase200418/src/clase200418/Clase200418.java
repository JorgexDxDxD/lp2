package clase200418;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

public class Clase200418 {
    public static void main(String[] args) {
        try{
            //Registrar el Driver
            Class.forName("com.mysql.jdbc.Driver");
            Connection con = DriverManager.getConnection
            ("jdbc:mysql://127.0.0.1/lp2", "root", "123456");
            
            //Creación del Statement
            Statement sentencia = con.createStatement();
            String sql = "SELECT * FROM PROFESOR";
            ResultSet rs = sentencia.executeQuery(sql);
            while(rs.next()){
                int id = rs.getInt("ID_PROFESOR");
                String nombre = rs.getString("NOMBRE");
                String apellido = rs.getString("APELLIDO");
                System.out.println(id + " "+nombre + " "+apellido);
            }
            

            System.out.println("Conexion exitosa");
            con.close();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    }
    
}
