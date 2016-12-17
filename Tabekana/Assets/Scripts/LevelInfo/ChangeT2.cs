using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeT2: MonoBehaviour {
	
	private Text txtRef;



	// Use this for initialization
	void Start () {
		String value = null;
		value = GlobalVariables.actLearnLvl;
		txtRef = GetComponent<Text>();//or provide from somewhere else (e.g. if you want via find GameObject.Find("CountText").GetComponent<Text>();)


		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);


			if (d==16){
				//Lesson 1
				//m_tittletex="Lesson 1";
				txtRef.text = "kyu";

			}
			if (d==17){
				//Lesson 2
				txtRef.text = "chu";
			}
			if (d==18) {
				//Lesson 3
				txtRef.text = "hyu";
			}
			if (d==19) {
				//Lesson 4
				txtRef.text = "ryu";
			}
			if (d==20) {
				//Lesson 5
				txtRef.text = "ju";
			}
			if (d==21) {
				//Lesson 6
				txtRef.text = "byu";
			}
			if (d==22) {
				//Lesson 7
				txtRef.text = "pyu";
			}



	}

	// Update is called once per frame
	void Update () {

	}
}