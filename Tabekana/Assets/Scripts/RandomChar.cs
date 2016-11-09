using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RandomSprite : MonoBehaviour {

	private string chr = "あいうえおかきくけこがぎぐげごさしすせそざじずぜぞたちつてとだぢづでどなにぬねのはひふへほばびぶべぼぱtぴぷぺぽまみむめもやゆよらりるれろわをん" +
		"アイウエオカキクケコサシスセソタチツテトナニヌネノハヒフヘホマミムメモヤユヨラリルレロワヲンガギグゲゴザジズゼゾダヂヅデドバビブベボパピプペポ";
	private char[] characters;
	private Text actualChar;

	public Font customFont;

	// Use this for initialization
	void Start () {
		if(chr != null){
			characters = chr.ToCharArray();
			GetComponent<Text>().text = characters[Random.Range (0, characters.Length)];
			GetComponent<Text> ().font = customFont;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
