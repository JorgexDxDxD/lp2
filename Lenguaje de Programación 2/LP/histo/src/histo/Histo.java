/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package histo;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.*;
import java.util.*;
import java.io.FileReader;
import java.io.BufferedReader;
import java.io.IOException;
import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
/**
 *
 * @author alulab14
 */
public class Histo extends JPanel {
    private static Histo histo;
    public Histo(){
        this.setFocusable(true);
    }
    public void paint(Graphics g){
        super.paint(g);
            g.drawString(String.valueOf(c1), 200, 30);
            g.drawString(String.valueOf(c2), 200, 50);
            g.drawLine(500,300,500,500);
            g.drawLine(200,300,200,500);
            g.drawLine(150,450,550,450);
            g.drawString(esp1,50 ,350 );
            g.drawString(esp2,50 ,400 );
            g.setColor(Color.red);
            g.fillRect(200,350,c1*20,10);
            g.setColor(Color.blue);
            g.fillRect(200,400,c2*20,10);
    }
    private static JButton generador;
    private static JTextField txt1;
    private static JTextField txt2;
    private static int c1 = 0;
    private static int c2 = 0;
    private static String esp1 = "";
    private static String esp2 ="";
    
    private static void initMarco(JFrame marco){
        marco.setSize(750,750);
        histo = new Histo();
        histo.setLayout(null);
        histo.setVisible(true);
        marco.add(histo);
        txt1 = new JTextField("");
        txt1.setBounds(120,20,50,20);
        txt2 = new JTextField("");
        txt2.setBounds(120,50,50,20);
        generador = new JButton("Actualizar");
        generador.setBounds(120,100,200,20);
        generador.addActionListener(new ActionListener(){
            public void actionPerformed(ActionEvent e){
                Connection con;
                try {
                    con = DriverManager.getConnection(
                            "jdbc:mysql://quilla.lab.inf.pucp.edu.pe/a20151521?useSSL=false",
                            "a20151521","QiDSz7");
                    String query = "{CALL CANT_NOMBRE_MED_ESP(?,?,?,?,?,?)}";
                    CallableStatement st = con.prepareCall(query);
                    st.registerOutParameter("_CANTIDAD_ESP1", java.sql.Types.INTEGER);
                    st.registerOutParameter("_CANTIDAD_ESP2", java.sql.Types.INTEGER);
                    st.registerOutParameter("_NOMBRE_ESP1", java.sql.Types.VARCHAR);
                    st.registerOutParameter("_NOMBRE_ESP2", java.sql.Types.VARCHAR);
                    st.setInt("_ID_ESPECIALIDAD1", Integer.parseInt(txt1.getText()));
                    st.setInt("_ID_ESPECIALIDAD2", Integer.parseInt(txt2.getText()));
                    st.execute();
                    c1 = st.getInt("_CANTIDAD_ESP1");
                    c2 = st.getInt("_CANTIDAD_ESP2");
                    esp1 = st.getString("_NOMBRE_ESP1");
                    esp2 = st.getString("_NOMBRE_ESP2");
                    con.close();
                    histo.repaint();
                } catch (SQLException ex) {
                    Logger.getLogger(Histo.class.getName()).log(Level.SEVERE, null, ex);
                    
                }
                
            }
        });
        histo.add(generador);
        histo.add(txt1);
        histo.add(txt2);
        marco.add(histo);
        marco.setVisible(true);
        marco.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws InterruptedException {
        // TODO code application logic here
        JFrame marco = new JFrame();
        initMarco(marco);

    }
    
}