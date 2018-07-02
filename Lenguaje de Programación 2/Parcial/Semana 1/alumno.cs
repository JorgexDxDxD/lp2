public class alumno : persona{
	private int semestre;
	private float CRAEST;
	
	public alumno (string nombreRecibe, int edadRecibe,int semestre, float CRAEST) : base(nombreRecibe,edadRecibe){
		this.semestre = semestre;
		this.CRAEST = CRAEST;
	}
	
	
}