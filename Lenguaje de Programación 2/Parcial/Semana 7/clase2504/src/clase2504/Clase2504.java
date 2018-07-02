package clase2504;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;

public class Clase2504 {

    public static void main(String[] args) throws Exception{
        
    Class.forName("com.mysql.jdbc.Driver");
    Connection con = DriverManager.getConnection
    ("jdbc:mysql://localhost/lp2?useSSL=false","root",
                    "123456");
    CallableStatement cs =
            con.prepareCall("{call "
                    + "INSERTAR_PROFESOR(?,?,?)}"
            );
    int idAsignado;
    cs.setString(2,"Braulio");
    cs.setString(3,"Murillo");
    cs.executeUpdate();
    idAsignado = cs.getInt(1);
    System.out.println(idAsignado);
    }
}
