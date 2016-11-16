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
		// Coges la salida que toque y haces un print de la letra

		print (letra);

		// Si ha ido bien devuelve true, si no devuelve false
		//return comoHaIdo;                                                 <---- COMENTADO
	}
}