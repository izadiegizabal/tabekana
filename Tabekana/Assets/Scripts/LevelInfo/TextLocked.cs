using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TextLocked : MonoBehaviour {

	private Text txtRef;
	// Use this for initialization
	void Start () {
		String value = null;
		value = GlobalVariables.actLearnLvl;

		Char delimiter = ' ';
		txtRef = GetComponent<Text>();
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		if (u.Equals ('h')) {
			//Hiragana
			if (GlobalVariables.levelUnlockHira + 1 < d) {
				txtRef.text = " ";
			} else {
				txtRef.text = "Level " + b.ToString ();

			}

		}
		if (u.Equals ('k')) {
			//Hiragana
			if (GlobalVariables.levelUnlockKata + 1 < d) {
				txtRef.text = " ";
			} else {
				txtRef.text = "Level " + b.ToString ();

			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
