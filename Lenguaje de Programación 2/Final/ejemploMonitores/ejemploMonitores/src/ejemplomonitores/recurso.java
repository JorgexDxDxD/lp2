package ejemplomonitores;
public class recurso {
    public int cantidad;
    public recurso(){
        System.out.println("Se ha creado el recurso");
        this.cantidad = 0;
        System.out.println("Cantidad: "+ this.cantidad);
    }
    public synchronized void producir() throws Exception{
        while (this.cantidad == 2){
            wait();
        }
        System.out.println("Se está produciendo...");
        int temp = this.cantidad;
        temp = temp + 1;
        this.cantidad = temp;
        System.out.println("Cantidad: "+ this.cantidad);
        notifyAll();
    }
    public synchronized void consumir() throws Exception{
        while (this.cantidad == 0){
            wait();
        }
        System.out.println("Se está consumiendo...");
        int temp = this.cantidad;
        temp = temp - 1;
        this.cantidad = temp;
        System.out.println("Cantidad: "+ this.cantidad);
        notifyAll();
    }
}
