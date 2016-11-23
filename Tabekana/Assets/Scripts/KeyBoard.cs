using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class KeyBoard : MonoBehaviour {

	string letra;

	//public static bool leerClic (char datosDelClic){   <---- COMENTADO
	public void leerClic (string datosDelClic){
		// Transformamos el clic en una letra
		letra = leeLetra(datosDelClic);
		// La escribimos por pantalla
		//return this.escribeLetra(letra);               <---- COMENTADO
		escribeLetra(letra);

	}

	// Funcion que recibe los datos del clic del usuario y 
	//   devuelve la letra a la que corresponde dicho clic
	private string leeLetra(string datosDelClic){
		// Segun los datosDelClic devuelve una letra u otra...
		letra = "A";                                //        <---- TENGO QUE INICIALIZARLA A ALGUN VALOR
		switch (datosDelClic) {
			// Primera linea
			case "Q":
				letra = "Q"; break;
			case "W":
				letra = "W"; break;
			case "E":
				letra = "E"; break;
			case "R":
				letra = "R"; break;
			case "T":
				letra = "T"; break;
			case "Y":
				letra = "Y"; break;
			case "U":
				letra = "U"; break;
			case "I":
				letra = "I"; break;
			case "O":
				letra = "O"; break;
			case "P":
				letra = "P"; break;

			// Segunda linea
			case "A":
				letra = "A"; break;
			case "S":
				letra = "S"; break;
			case "D":
				letra = "D"; break;
			case "F":
				letra = "F"; break;
			case "G":
				letra = "G"; break;
			case "H":
				letra = "H"; break;
			case "J":
				letra = "J"; break;
			case "K":
				letra = "K"; break;
			case "L":
				letra = "L"; break;

			// Tercera linea
			case "Z":
				letra = "Z"; break;
			case "X":
				letra = "X"; break;
			case "C":
				letra = "C"; break;
			case "V":
				letra = "V"; break;
			case "B":
				letra = "B"; break;
			case "N":
				letra = "N"; break;
			case "M":
				letra = "M"; break;
		}
		return letra;
	}

	// Funcion que escribe la letra que recibe por parametro en pantalla
	//private static bool escribeLetra(char letra){                         <---- COMENTADO
	private static void escribeLetra(string letra){
		// Cogemos la salida que toque y hacemos un print de la letra

		print (letra);

		//GlobalVariables.array3Characters = new string[] { "_", "_", "_" };

		if (GlobalVariables.array3Characters [0] == "_") {
			GlobalVariables.array3Characters [0] = letra;
		} 
		else if (GlobalVariables.array3Characters [1] == "_") {
			GlobalVariables.array3Characters [1] = letra;
		} 
		else if (GlobalVariables.array3Characters [2] == "_") {
			GlobalVariables.array3Characters [2] = letra;
		}
//		for (int i = 0; i < GlobalVariables.array3Characters.Length; i++) {
//			print (GlobalVariables.array3Characters[i]);                     // <---- MUESTRA EL ARRAY EN LA CONSOLA   
//		}
	}

	void OnGUI () {
	//	GUILayout.Label(letra);                                               // <---- MUESTRA LA LETRA POR PANTALLA   
	//	for (int i = 0; i < GlobalVariables.array3Characters.Length; i++) {
	//		GUILayout.Label (GlobalVariables.array3Characters [i]);           // <---- MUESTRA EL ARRAY POR PANTALLA POR POSICIONES Y EN VERTICAL 
	//	}
		if (GlobalVariables.array3Characters [1] != "_") {
			GUILayout.Label (string.Join ("", GlobalVariables.array3Characters)); // <---- MUESTRA EL ARRAY POR PANTALLA BIEN!   
		} 
		else {
			//GlobalVariables.array3Characters [3] = "";   --> ERROR! 
			GlobalVariables.array3Characters = new string [2] {GlobalVariables.array3Characters[0], GlobalVariables.array3Characters[1]};	// Lo convierte en un array de dos posiciones
			GUILayout.Label (string.Join ("", GlobalVariables.array3Characters)); // <---- MUESTRA EL ARRAY POR PANTALLA BIEN! 
			GlobalVariables.array3Characters = new string [3] {GlobalVariables.array3Characters[0], GlobalVariables.array3Characters[1], "_"};	// Lo deja con 3 posiciones para la siguiente vez
		}

	}
}