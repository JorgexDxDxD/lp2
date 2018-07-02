
package cliente_java_s_c3;

import javax.xml.bind.annotation.XmlAccessType;
import javax.xml.bind.annotation.XmlAccessorType;
import javax.xml.bind.annotation.XmlRootElement;
import javax.xml.bind.annotation.XmlType;


/**
 * <p>Clase Java para anonymous complex type.
 * 
 * <p>El siguiente fragmento de esquema especifica el contenido que se espera que haya en esta clase.
 * 
 * <pre>
 * &lt;complexType>
 *   &lt;complexContent>
 *     &lt;restriction base="{http://www.w3.org/2001/XMLSchema}anyType">
 *       &lt;sequence>
 *         &lt;element name="restarResult" type="{http://www.w3.org/2001/XMLSchema}double"/>
 *       &lt;/sequence>
 *     &lt;/restriction>
 *   &lt;/complexContent>
 * &lt;/complexType>
 * </pre>
 * 
 * 
 */
@XmlAccessorType(XmlAccessType.FIELD)
@XmlType(name = "", propOrder = {
    "restarResult"
})
@XmlRootElement(name = "restarResponse")
public class RestarResponse {

    protected double restarResult;

    /**
     * Obtiene el valor de la propiedad restarResult.
     * 
     */
    public double getRestarResult() {
        return restarResult;
    }

    /**
     * Define el valor de la propiedad restarResult.
     * 
     */
    public void setRestarResult(double value) {
        this.restarResult = value;
    }

}
