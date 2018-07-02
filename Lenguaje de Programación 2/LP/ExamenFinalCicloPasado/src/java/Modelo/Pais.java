/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author jorge
 */
public class Pais {

    public String getNOMBRE() {
        return NOMBRE;
    }

    public void setNOMBRE(String NOMBRE) {
        this.NOMBRE = NOMBRE;
    }

    public int getID_PAIS_CLASIFICADO() {
        return ID_PAIS_CLASIFICADO;
    }

    public void setID_PAIS_CLASIFICADO(int ID_PAIS_CLASIFICADO) {
        this.ID_PAIS_CLASIFICADO = ID_PAIS_CLASIFICADO;
    }

    public int getCATEGORIA_SORTEO() {
        return CATEGORIA_SORTEO;
    }

    public void setCATEGORIA_SORTEO(int CATEGORIA_SORTEO) {
        this.CATEGORIA_SORTEO = CATEGORIA_SORTEO;
    }

    public String getGRUPO() {
        return GRUPO;
    }

    public void setGRUPO(String GRUPO) {
        this.GRUPO = GRUPO;
    }
    private int ID_PAIS_CLASIFICADO;
    private int CATEGORIA_SORTEO;
    private String GRUPO;
    private String NOMBRE;
}
