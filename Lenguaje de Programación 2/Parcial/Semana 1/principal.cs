public class principal{
	public static void Main(string[] args){
		persona p1 = new persona("Juan",33);
		persona p2 = new persona("Karen");
		persona p3 = new persona();
		p2.Edad = 22;
		p3.Nombre = "Manuel";
		p3.Edad = 30;
		p1.mostrarNombre();
		p2.mostrarNombre();
		p3.mostrarNombre();
		alumno a1 = new alumno("Luis",28,2,49.3f);
		a1.mostrarNombre();
	}
}