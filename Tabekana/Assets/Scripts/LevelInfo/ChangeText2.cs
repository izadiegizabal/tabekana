﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeText2: MonoBehaviour {
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
				txtRef.text = "i";

			}
			if (d==2){
				//Lesson 2
				txtRef.text = "ki";
			}
			if (d==3) {
				//Lesson 3
				txtRef.text = "shi";
			}
			if (d==4) {
				//Lesson 4
				txtRef.text = "chi";
			}
			if (d==5) {
				//Lesson 5
				txtRef.text = "ni";
			}
			if (d==6) {
				//Lesson 6
				txtRef.text = "hi";
			}
			if (d==7) {
				//Lesson 7
				txtRef.text = "mi";
			}
			if (d==8) {
				//Lesson 8
				txtRef.text = "yu";
			}
			if (d==9) {
				//Lesson 9
				txtRef.text = "ri";
			}
			if (d==10) {
				//Lesson 10
				txtRef.text = "wo";
			}
			if (d==11) {
				//Lesson 11
				txtRef.text = "gi";
			}
			if (d==12) {
				//Lesson 12
				txtRef.text = "ji";
			}
			if (d==13) {
				//Lesson 13
				txtRef.text = "di";
			}
			if (d==14) {
				//Lesson 14
				txtRef.text = "bi";
			}
			if (d==15) {
				//Lesson 15
				txtRef.text = "pi";
			}


	}

	// Update is called once per frame
	void Update () {

	}
}
