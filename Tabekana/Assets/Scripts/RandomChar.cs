using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomChar : MonoBehaviour {

	//We add the kana characters that we want to show
	private string chr = "あいうえおかきくけこがぎぐげごさしすせそざじずぜぞたちつてとだぢづでどなにぬねのはひふへほばびぶべぼぱぴぷぺぽまみむめもやゆよらりるれろわをん" +
		"アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポ";
	//We create an array to hold the characters
	private char[] characters;

	public Font customFont;
	public int fontSize = 50;
	// Use this for initialization
	void Start () {
		if(chr != null){

			//we insert the chars into the array
			characters = chr.ToCharArray();
			//we chose a random char from the array and we update the text component
			GetComponent<Text>().text = characters[Random.Range (0, characters.Length)].ToString();
			//we apply the desired modifications to the font
			GetComponent<Text> ().font = customFont;
			GetComponent<Text> ().fontSize = fontSize;

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
