package ejemplomonitores;

public class productor extends Thread{
    private recurso r;
    public productor(recurso r){
        this.r = r;
    }
    public void run() {
        try{
            this.r.producir();
        }catch(Exception e){}
    }
}