using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class KeyBoard : MonoBehaviour {

	string letra;

	public void leerClic (string datosDelClic){
		// Transformamos el clic en una letra
		letra = leeLetra(datosDelClic);
		// La escribimos por pantalla
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
				letra = "q"; break;
			case "W":
				letra = "w"; break;
			case "E":
				letra = "e"; break;
			case "R":
				letra = "r"; break;
			case "T":
				letra = "t"; break;
			case "Y":
				letra = "y"; break;
			case "U":
				letra = "u"; break;
			case "I":
				letra = "i"; break;
			case "O":
				letra = "o"; break;
			case "P":
				letra = "p"; break;

			// Segunda linea
			case "A":
				letra = "a"; break;
			case "S":
				letra = "s"; break;
			case "D":
				letra = "d"; break;
			case "F":
				letra = "f"; break;
			case "G":
				letra = "g"; break;
			case "H":
				letra = "h"; break;
			case "J":
				letra = "j"; break;
			case "K":
				letra = "k"; break;
			case "L":
				letra = "l"; break;

			// Tercera linea
			case "Z":
				letra = "z"; break;
			case "X":
				letra = "x"; break;
			case "C":
				letra = "c"; break;
			case "V":
				letra = "v"; break;
			case "B":
				letra = "b"; break;
			case "N":
				letra = "n"; break;
			case "M":
				letra = "m"; break;
		}
		return letra;
	}

	// Funcion que escribe la letra que recibe por parametro en pantalla
	//private static bool escribeLetra(char letra){                         <---- COMENTADO
	private static void escribeLetra(string letra){
		// Cogemos la salida que toque y hacemos un print de la letra (a la consola)

		if (GlobalVariables.array3Characters [0] == "_") {
			GlobalVariables.array3Characters [0] = letra;
			GlobalVariables.array3Characters [1] = "_";
			//we inform that we've updated the input
			GlobalVariables.inputArrayChanged = true;
		} 
		else if (GlobalVariables.array3Characters [1] == "_") {
			GlobalVariables.array3Characters [1] = letra;
			GlobalVariables.array3Characters [2] = "_";
			//we inform that we've updated the input
			GlobalVariables.inputArrayChanged = true;
		} 
		else if (GlobalVariables.array3Characters [2] == "_") {
			GlobalVariables.array3Characters [2] = letra;
			//we inform that we've updated the input
			GlobalVariables.inputArrayChanged = true;
		}
	}
}