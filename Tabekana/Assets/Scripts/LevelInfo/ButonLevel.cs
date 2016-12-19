using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ButonLevel : MonoBehaviour {
	private string level;
	// Use this for initialization
	public void Click () {
		// Guardo en la variable global el nivel
		//GlobalVariables.actGameLvl = level;
		level = GlobalVariables.actLearnLvl;
		//GlobalVariables


		Char delimiter = ' ';
		String[] substrings = level.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);


		if (u.Equals ('h')) {
			//Hiragana
			if (GlobalVariables.levelUnlockHira+1 >= d) {
				GlobalVariables.actGameLvl = level;
				SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);

			}

		}if (u.Equals ('k')) {
			//Hiragana
			if (GlobalVariables.levelUnlockKata+1 >= d) {
				GlobalVariables.actGameLvl = level;
				SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);

			}

		}

		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
	}
	
	// Update is called once per frame

}
