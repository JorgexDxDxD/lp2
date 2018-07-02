public class principal{
	public static void main(String[] args){
		persona p1 = new persona("Juan",33);
		persona p2 = new persona("Karen");
		persona p3 = new persona();
		p2.setEdad(22);
		p3.setNombre("Manuel");
		p3.setEdad(20);
		p1.mostrarNombre();
		p2.mostrarNombre();
		p3.mostrarNombre();
		
		alumno a1 = new alumno("Luis", 29, 57.2f, 2);
		a1.mostrarNombre();
		String s = a1.obtenerNota();
		System.out.println("hola a todos "+ s);
		a1 = null;
		System.gc();
	}
}