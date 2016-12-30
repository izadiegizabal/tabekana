using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeT4: MonoBehaviour {

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


			if (d==16){
				txtRef.text = "sha";
			}
			if (d==17){
				//Lesson 2
				txtRef.text = "nya";
			}
			if (d==18) {
				//Lesson 3
				txtRef.text = "mya";
			}
			if (d==19) {
				//Lesson 4
				txtRef.text = "gya";
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

	// Update is called once per frame
	void Update () {

	}
}