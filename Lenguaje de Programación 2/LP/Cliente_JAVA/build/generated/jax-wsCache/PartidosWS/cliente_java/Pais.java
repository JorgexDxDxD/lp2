
package cliente_java;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para pais complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType name="pais">
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="CATEGORIA_SORTEO" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="GRUPO" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *         &lt;element name="ID_PAIS_CLASIFICADO" type="{http://www.w3.org/2001/XMLSchema}int"/>
 *         &lt;element name="NOMBRE" type="{http://www.w3.org/2001/XMLSchema}string" minOccurs="0"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "pais", propOrder = {
    "categoriasorteo",
    "grupo",
    "idpaisclasificado",
    "nombre"
})
public class Pais {

    @XmlElement(name = "CATEGORIA_SORTEO")
    protected int categoriasorteo;
    @XmlElement(name = "GRUPO")
    protected String grupo;
    @XmlElement(name = "ID_PAIS_CLASIFICADO")
    protected int idpaisclasificado;
    @XmlElement(name = "NOMBRE")
    protected String nombre;

    /**
     * Obtiene el valor de la propiedad categoriasorteo.
     * 
     */
    public int getCATEGORIASORTEO() {
        return categoriasorteo;
    }

    /**
     * Define el valor de la propiedad categoriasorteo.
     * 
     */
    public void setCATEGORIASORTEO(int value) {
        this.categoriasorteo = value;
    }

    /**
     * Obtiene el valor de la propiedad grupo.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getGRUPO() {
        return grupo;
    }

    /**
     * Define el valor de la propiedad grupo.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setGRUPO(String value) {
        this.grupo = value;
    }

    /**
     * Obtiene el valor de la propiedad idpaisclasificado.
     * 
     */
    public int getIDPAISCLASIFICADO() {
        return idpaisclasificado;
    }

    /**
     * Define el valor de la propiedad idpaisclasificado.
     * 
     */
    public void setIDPAISCLASIFICADO(int value) {
        this.idpaisclasificado = value;
    }

    /**
     * Obtiene el valor de la propiedad nombre.
     * 
     * @return
     *     possible object is
     *     {@link String }
     *     
     */
    public String getNOMBRE() {
        return nombre;
    }

    /**
     * Define el valor de la propiedad nombre.
     * 
     * @param value
     *     allowed object is
     *     {@link String }
     *     
     */
    public void setNOMBRE(String value) {
        this.nombre = value;
    }

}
