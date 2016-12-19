using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LevelLocked : MonoBehaviour {
	public Sprite locke;
	public Image imagen;	
	// Use this for initialization
	void Start () {
		String value = null;
		value = GlobalVariables.actLearnLvl;

		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		if (u.Equals ('h')) {
			//Hiragana
			if (GlobalVariables.levelUnlockHira+1 < d) {
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = locke;
			}

		}
		if (u.Equals ('k')) {
			//Hiragana
			if (GlobalVariables.levelUnlockKata+1 < d) {
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = locke;
			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
