
package cliente_java;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the cliente_java package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _EliminarPartidoResponse_QNAME = new QName("http://Servicio/", "eliminarPartidoResponse");
    private final static QName _ListarPartidos_QNAME = new QName("http://Servicio/", "listarPartidos");
    private final static QName _ListarPaisesResponse_QNAME = new QName("http://Servicio/", "listarPaisesResponse");
    private final static QName _EliminarPartido_QNAME = new QName("http://Servicio/", "eliminarPartido");
    private final static QName _ListarPaises_QNAME = new QName("http://Servicio/", "listarPaises");
    private final static QName _ListarPartidosResponse_QNAME = new QName("http://Servicio/", "listarPartidosResponse");
    private final static QName _RegistrarPartidoResponse_QNAME = new QName("http://Servicio/", "registrarPartidoResponse");
    private final static QName _RegistrarPartido_QNAME = new QName("http://Servicio/", "registrarPartido");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: cliente_java
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link EliminarPartidoResponse }
     * 
     */
    public EliminarPartidoResponse createEliminarPartidoResponse() {
        return new EliminarPartidoResponse();
    }

    /**
     * Create an instance of {@link ListarPartidos }
     * 
     */
    public ListarPartidos createListarPartidos() {
        return new ListarPartidos();
    }

    /**
     * Create an instance of {@link ListarPaisesResponse }
     * 
     */
    public ListarPaisesResponse createListarPaisesResponse() {
        return new ListarPaisesResponse();
    }

    /**
     * Create an instance of {@link EliminarPartido }
     * 
     */
    public EliminarPartido createEliminarPartido() {
        return new EliminarPartido();
    }

    /**
     * Create an instance of {@link ListarPaises }
     * 
     */
    public ListarPaises createListarPaises() {
        return new ListarPaises();
    }

    /**
     * Create an instance of {@link ListarPartidosResponse }
     * 
     */
    public ListarPartidosResponse createListarPartidosResponse() {
        return new ListarPartidosResponse();
    }

    /**
     * Create an instance of {@link RegistrarPartidoResponse }
     * 
     */
    public RegistrarPartidoResponse createRegistrarPartidoResponse() {
        return new RegistrarPartidoResponse();
    }

    /**
     * Create an instance of {@link RegistrarPartido }
     * 
     */
    public RegistrarPartido createRegistrarPartido() {
        return new RegistrarPartido();
    }

    /**
     * Create an instance of {@link Partido }
     * 
     */
    public Partido createPartido() {
        return new Partido();
    }

    /**
     * Create an instance of {@link Pais }
     * 
     */
    public Pais createPais() {
        return new Pais();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link EliminarPartidoResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "eliminarPartidoResponse")
    public JAXBElement<EliminarPartidoResponse> createEliminarPartidoResponse(EliminarPartidoResponse value) {
        return new JAXBElement<EliminarPartidoResponse>(_EliminarPartidoResponse_QNAME, EliminarPartidoResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarPartidos }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "listarPartidos")
    public JAXBElement<ListarPartidos> createListarPartidos(ListarPartidos value) {
        return new JAXBElement<ListarPartidos>(_ListarPartidos_QNAME, ListarPartidos.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarPaisesResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "listarPaisesResponse")
    public JAXBElement<ListarPaisesResponse> createListarPaisesResponse(ListarPaisesResponse value) {
        return new JAXBElement<ListarPaisesResponse>(_ListarPaisesResponse_QNAME, ListarPaisesResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link EliminarPartido }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "eliminarPartido")
    public JAXBElement<EliminarPartido> createEliminarPartido(EliminarPartido value) {
        return new JAXBElement<EliminarPartido>(_EliminarPartido_QNAME, EliminarPartido.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarPaises }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "listarPaises")
    public JAXBElement<ListarPaises> createListarPaises(ListarPaises value) {
        return new JAXBElement<ListarPaises>(_ListarPaises_QNAME, ListarPaises.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link ListarPartidosResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "listarPartidosResponse")
    public JAXBElement<ListarPartidosResponse> createListarPartidosResponse(ListarPartidosResponse value) {
        return new JAXBElement<ListarPartidosResponse>(_ListarPartidosResponse_QNAME, ListarPartidosResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RegistrarPartidoResponse }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "registrarPartidoResponse")
    public JAXBElement<RegistrarPartidoResponse> createRegistrarPartidoResponse(RegistrarPartidoResponse value) {
        return new JAXBElement<RegistrarPartidoResponse>(_RegistrarPartidoResponse_QNAME, RegistrarPartidoResponse.class, null, value);
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link RegistrarPartido }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://Servicio/", name = "registrarPartido")
    public JAXBElement<RegistrarPartido> createRegistrarPartido(RegistrarPartido value) {
        return new JAXBElement<RegistrarPartido>(_RegistrarPartido_QNAME, RegistrarPartido.class, null, value);
    }

}
