using System.Collections.Generic;
public class Principal{
	public static void Main(){
		Equipu objEquipu = new Equipu();
		
		Profesor p1 = new Profesor(46891,"Andrea Montenegro",estadoProf.TC);
		
		Equipo eq = new Equipo();
		eq.agregarMiembro(p1);
		
		objEquipu.agregarEquipo(eq);
		
		string reporte = objEquipu.consultarEquipo(0);
		
		System.Console.Write(reporte);
	}
}