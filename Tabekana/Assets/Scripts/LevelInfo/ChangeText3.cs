﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeText3: MonoBehaviour {
	private Text txtRef;



	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)
		String value = null;
		value = GlobalVariables.actLearnLvl;

		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string b = substrings [1];
		int d = int.Parse (b);


			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				txtRef.text = "u";

			}
			if (d==2){
				//Lesson 2
				txtRef.text = "ku";
			}
			if (d==3) {
				//Lesson 3
				txtRef.text = "su";
			}
			if (d==4) {
				//Lesson 4
				txtRef.text = "tsu";
			}
			if (d==5) {
				//Lesson 5
				txtRef.text = "nu";
			}
			if (d==6) {
				//Lesson 6
				txtRef.text = "fu";
			}
			if (d==7) {
				//Lesson 7
				txtRef.text = "mu";
			}
			if (d==8) {
				//Lesson 8
				txtRef.text = "yo";
			}
			if (d==9) {
				//Lesson 9
				txtRef.text = "ru";
			}
			if (d==10) {
				//Lesson 10
				txtRef.text = "n";
			}
			if (d==11) {
				//Lesson 11
				txtRef.text = "gu";
			}
			if (d==12) {
				//Lesson 12
				txtRef.text = "zu";
			}
			if (d==13) {
				//Lesson 13
				txtRef.text = "du";
			}
			if (d==14) {
				//Lesson 14
				txtRef.text = "bu";
			}
			if (d==15) {
				//Lesson 15
				txtRef.text = "pu";
			}


	}

	// Update is called once per frame
	void Update () {

	}
}
