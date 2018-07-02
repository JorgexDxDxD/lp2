package estrategiasdibujo;
import java.awt.Graphics;
import java.awt.Rectangle;
import javax.swing.JFrame;
import javax.swing.JPanel;
public class juego extends JPanel{
    
    private int x = 0;
    private int y = 0;
    private int xa = 1;
    private int ya = 1;
    private int xR = 0;
    
    public void paint(Graphics g){
        super.paint(g);
        g.fillOval(x, y, 30, 30);
        g.fillRect(xR, 400, 100, 10);
    }
    
    public void mover(){
        if(x+xa<0) xa = 1;
        if(y+ya<0) ya = 1;
        if(x+xa>getWidth()-30) xa=-1;
        if(colision()) ya = -1;
        if(y+ya>getHeight()-30) ya=-1;
        x=x+xa;
        y=y+ya;
    }
    
    public boolean colision(){
        Rectangle r1 = new Rectangle(x, y, 30, 30);
        Rectangle r2 = new Rectangle(xR, 400, 100, 10);
        return r1.getBounds().intersects
        (r2.getBounds());
    }
    
    public juego(){
    addKeyListener(new java.awt.event.KeyAdapter(){
       public void keyPressed(java.awt.event.KeyEvent evt) {
           if (evt.getKeyCode()==39){
               xR=xR+5;
           }
           if (evt.getKeyCode()==38){
               xR=xR-5;
           }
       }
    });
        setFocusable(true);
    }
    
    public static void main(String[] args) throws Exception{
        JFrame marco = new JFrame();
        juego j = new juego();
        marco.add(j);
        marco.setVisible(true);
        marco.setSize(500,500);
        
        while(true){
            j.mover();
            j.repaint();
            Thread.sleep(10);
        }
    }
}
