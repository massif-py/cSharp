//ERROR 13: CARACTER INVALIDO RESPECTO A s/S/n/N PARA LA DECISION DEL BUCLE.
using System;				
public class promedioCalificaciones
{
	public static void Main()
	{	
		int counter = 0;
		float calif = 0;
		float calif_Acum = 0;
		string option = "s";
		while(option == "s" || option == "S"){
			Console.WriteLine("Ingresa la calificacion:");
			calif = float.Parse(Console.ReadLine());
			if(calif < 0.0 || calif > 10.0){
				Console.WriteLine("La calificación ingresada es incorrecta.");
				Console.WriteLine(calif + " debe de estar entre 0.0 y 10.0");
				Console.WriteLine("Desea introducir otra calificación [s/S][n/N]");
				option = Console.ReadLine();
				if(option == "n" || option == "N"){
					break;
				}else if(option == "s" || option =="S"){
					continue;
				}else{
					Console.WriteLine("ERROR 13: PONGASE EN CONTACTO CON SU ADMINISTRADOR DEL SISTEMA Y REPORTE EL NUMERO DE ERROR.");
					break;
				}
			}else{
				counter += 1;
				calif_Acum += calif;
				Console.WriteLine("Desea introducir otra calificacion?: [s/S][n/N]");
				option = Console.ReadLine();
				if(option == "n" || option == "N"){
					break;
				}else if(option == "s" || option =="S"){
					continue;
				}else{
					Console.WriteLine("ERROR 13: PONGASE EN CONTACTO CON SU ADMINISTRADOR DEL SISTEMA Y REPORTE EL NUMERO DE ERROR.");
					break;
				}
			}
		}		
		Console.WriteLine("El promedio de calificaciones es: " + (calif_Acum / counter));		
	}
}