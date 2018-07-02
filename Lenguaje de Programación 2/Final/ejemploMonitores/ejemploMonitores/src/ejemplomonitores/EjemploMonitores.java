package ejemplomonitores;

public class EjemploMonitores {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        recurso r = new recurso();
        productor p1 = new productor(r);
        productor p2 = new productor(r);
        consumidor c1 = new consumidor(r);
        consumidor c2 = new consumidor(r);
        p1.start();
        p2.start();
        c1.start();
        c2.start();
    }
    
}
