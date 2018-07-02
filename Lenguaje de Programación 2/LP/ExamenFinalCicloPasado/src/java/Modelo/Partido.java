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
public class Partido {

    public int getEQUIPO_A() {
        return EQUIPO_A;
    }

    public void setEQUIPO_A(int EQUIPO_A) {
        this.EQUIPO_A = EQUIPO_A;
    }

    public int getEQUIPO_B() {
        return EQUIPO_B;
    }

    public void setEQUIPO_B(int EQUIPO_B) {
        this.EQUIPO_B = EQUIPO_B;
    }

    public int getGOLES_EQUIPO_A() {
        return GOLES_EQUIPO_A;
    }

    public void setGOLES_EQUIPO_A(int GOLES_EQUIPO_A) {
        this.GOLES_EQUIPO_A = GOLES_EQUIPO_A;
    }

    public int getGOLES_EQUIPO_B() {
        return GOLES_EQUIPO_B;
    }

    public void setGOLES_EQUIPO_B(int GOLES_EQUIPO_B) {
        this.GOLES_EQUIPO_B = GOLES_EQUIPO_B;
    }

    public boolean isJUGADO() {
        return JUGADO;
    }

    public void setJUGADO(boolean JUGADO) {
        this.JUGADO = JUGADO;
    }
    private int EQUIPO_A;
    private int EQUIPO_B;
    private int GOLES_EQUIPO_A;
    private int GOLES_EQUIPO_B;
    private boolean JUGADO;
}
