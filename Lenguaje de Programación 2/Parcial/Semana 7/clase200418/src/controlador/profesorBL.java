/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package controlador;

import accesoDatos.profesorDA;
import java.util.ArrayList;
import modelo.profesor;

/**
 *
 * @author Freddy
 */
public class profesorBL {
    
    private profesorDA accesoDatos;
    
    public profesorBL(){
        accesoDatos = new profesorDA();
    }
    
    public void registrarProfesor(profesor p){
        accesoDatos.registrar(p);
    }
    
    public ArrayList<profesor> listarProfesores(){
        return accesoDatos.listarProfesores();
    }
    
}
