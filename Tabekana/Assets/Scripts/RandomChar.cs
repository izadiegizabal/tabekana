using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomChar : MonoBehaviour {

	private string chr = "あいうえおかきくけこがぎぐげごさしすせそざじずぜぞたちつてとだぢづでどなにぬねのはひふへほばびぶべぼぱぴぷぺぽまみむめもやゆよらりるれろわをん" +
		"アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポ";
	private char[] characters;
	private Text actualChar;

	public Font customFont;
	public int fontSize = 50;
	// Use this for initialization
	void Start () {
		if(chr != null){
			characters = chr.ToCharArray();
			GetComponent<Text>().text = characters[Random.Range (0, characters.Length)].ToString();
			GetComponent<Text> ().font = customFont;
			GetComponent<Text> ().fontSize = fontSize;

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
