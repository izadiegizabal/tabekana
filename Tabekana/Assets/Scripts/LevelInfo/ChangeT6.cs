﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeT6: MonoBehaviour {
	//public LevelInf codigo;
	String value = "h 16";
	//en esta varibale cambiar por el metodo que lanza alba 
	private Text txtRef;



	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)


		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		if (u.Equals('h')) {
			//Hiragana
			if (d==16){
				txtRef.text = "sho";
			}
			if (d==17){
				//Lesson 2
				txtRef.text = "nyo";
			}
			if (d==18) {
				//Lesson 3
				txtRef.text = "myo";
			}
			if (d==19) {
				//Lesson 4
				txtRef.text = "gyo";
			}
			if (d==20) {
				//Lesson 5
				txtRef.text = " ";
			}
			if (d==21) {
				//Lesson 6
				txtRef.text = " ";
			}
			if (d==22) {
				//Lesson 7
				txtRef.text = " ";
			}



		}
	}

	// Update is called once per frame
	void Update () {

	}
}