﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeText5: MonoBehaviour {
	//public LevelInf codigo;
	String value = "h 15";
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
			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				txtRef.text = "o";

			}
			if (d==2){
				//Lesson 2
				txtRef.text = "ko";
			}
			if (d==3) {
				//Lesson 3
				txtRef.text = "so";
			}
			if (d==4) {
				//Lesson 4
				txtRef.text = "to";
			}
			if (d==5) {
				//Lesson 5
				txtRef.text = "no";
			}
			if (d==6) {
				//Lesson 6
				txtRef.text = "ho";
			}
			if (d==7) {
				//Lesson 7
				txtRef.text = "mo";
			}
			if (d==8) {
				//Lesson 8
				txtRef.text = " ";
			}
			if (d==9) {
				//Lesson 9
				txtRef.text = "ro";
			}
			if (d==10) {
				//Lesson 10
				txtRef.text = " ";
			}
			if (d==11) {
				//Lesson 11
				txtRef.text = "go";
			}
			if (d==12) {
				//Lesson 12
				txtRef.text = "zo";
			}
			if (d==13) {
				//Lesson 13
				txtRef.text = "do";
			}
			if (d==14) {
				//Lesson 14
				txtRef.text = "bo";
			}
			if (d==15) {
				//Lesson 15
				txtRef.text = "po";
			}

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
