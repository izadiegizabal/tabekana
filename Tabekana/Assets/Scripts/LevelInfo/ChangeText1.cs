
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeText1: MonoBehaviour {
	private Text txtRef;



	// Use this for initialization
	void Start () {
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)
		String value = null;
		value = GlobalVariables.actLearnLvl;

		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);


			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				txtRef.text = "a";

			}
			if (d==2){
				//Lesson 2
				txtRef.text = "ka";
			}
			if (d==3) {
				//Lesson 3
				txtRef.text = "sa";
			}
			if (d==4) {
				//Lesson 4
				txtRef.text = "ta";
			}
			if (d==5) {
				//Lesson 5
				txtRef.text = "na";
			}
			if (d==6) {
				//Lesson 6
				txtRef.text = "ha";
			}
			if (d==7) {
				//Lesson 7
				txtRef.text = "ma";
			}
			if (d==8) {
				//Lesson 8
				txtRef.text = "ya";
			}
			if (d==9) {
				//Lesson 9
				txtRef.text = "ra";
			}
			if (d==10) {
				//Lesson 10
				txtRef.text = "wa";
			}
			if (d==11) {
				//Lesson 11
				txtRef.text = "ga";
			}
			if (d==12) {
				//Lesson 12
				txtRef.text = "za";
			}
			if (d==13) {
				//Lesson 13
				txtRef.text = "da";
			}
			if (d==14) {
				//Lesson 14
				txtRef.text = "ba";
			}
			if (d==15) {
				//Lesson 15
				txtRef.text = "pa";
			}


	}

	// Update is called once per frame
	void Update () {

	}
}
