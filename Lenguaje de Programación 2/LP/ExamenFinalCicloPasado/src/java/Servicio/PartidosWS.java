/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Servicio;

import AccesoDatos.PaisDA;
import AccesoDatos.PartidoDA;
import Modelo.*;
import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

/**
 *
 * @author jorge
 */
@WebService(serviceName = "PartidosWS")
public class PartidosWS {

    private PaisDA accesoPais ; 
    private PartidoDA accesoPartido;
    public PartidosWS(){
        accesoPais=new PaisDA();
        accesoPartido= new PartidoDA();
    }
    
//    @WebMethod(operationName = "hello")
    //@WebParam(name = "name") String txt
    public ArrayList<Pais> listarPaises() {
        ArrayList<Pais> lista = accesoPais.listarPaises();
        return lista;
    }
    
    public ArrayList<Partido> listarPartidos(){
        return accesoPartido.listarPartidos();
    }
    
    public void registrarPartido(Partido p){
        accesoPartido.registrarPartido(p);
    }
    
    public void eliminarPartido(Partido p){
        accesoPartido.eliminarResultado(p);
    }
}
