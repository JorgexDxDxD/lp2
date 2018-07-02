
package cliente_java;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para partido complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="partido">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="EQUIPO_A" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="EQUIPO_B" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="GOLES_EQUIPO_A" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="GOLES_EQUIPO_B" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="JUGADO" type="{http://www.w3.org/2001/XMLSchema}boolean"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "partido", propOrder = {
    "equipoa",
    "equipob",
    "golesequipoa",
    "golesequipob",
    "jugado"
})
public class Partido {

    @XmlElement(name = "EQUIPO_A")
    protected int equipoa;
    @XmlElement(name = "EQUIPO_B")
    protected int equipob;
    @XmlElement(name = "GOLES_EQUIPO_A")
    protected int golesequipoa;
    @XmlElement(name = "GOLES_EQUIPO_B")
    protected int golesequipob;
    @XmlElement(name = "JUGADO")
    protected boolean jugado;

    /**
     * Obtiene el valor de la propiedad equipoa.
     * 
     */
    public int getEQUIPOA() {
        return equipoa;
    }

    /**
     * Define el valor de la propiedad equipoa.
     * 
     */
    public void setEQUIPOA(int value) {
        this.equipoa = value;
    }

    /**
     * Obtiene el valor de la propiedad equipob.
     * 
     */
    public int getEQUIPOB() {
        return equipob;
    }

    /**
     * Define el valor de la propiedad equipob.
     * 
     */
    public void setEQUIPOB(int value) {
        this.equipob = value;
    }

    /**
     * Obtiene el valor de la propiedad golesequipoa.
     * 
     */
    public int getGOLESEQUIPOA() {
        return golesequipoa;
    }

    /**
     * Define el valor de la propiedad golesequipoa.
     * 
     */
    public void setGOLESEQUIPOA(int value) {
        this.golesequipoa = value;
    }

    /**
     * Obtiene el valor de la propiedad golesequipob.
     * 
     */
    public int getGOLESEQUIPOB() {
        return golesequipob;
    }

    /**
     * Define el valor de la propiedad golesequipob.
     * 
     */
    public void setGOLESEQUIPOB(int value) {
        this.golesequipob = value;
    }

    /**
     * Obtiene el valor de la propiedad jugado.
     * 
     */
    public boolean isJUGADO() {
        return jugado;
    }

    /**
     * Define el valor de la propiedad jugado.
     * 
     */
    public void setJUGADO(boolean value) {
        this.jugado = value;
    }

}
