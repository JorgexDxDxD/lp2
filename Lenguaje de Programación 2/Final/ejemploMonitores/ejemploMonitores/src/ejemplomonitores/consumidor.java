package ejemplomonitores;

public class consumidor extends Thread{
    private recurso r;
    public consumidor(recurso r){
        this.r = r;
    }
    public void run(){
        try{
            this.r.consumir();
        }catch(Exception e){}
    }
}
