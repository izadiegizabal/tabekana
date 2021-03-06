﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelUnlockHiragana : MonoBehaviour {

    public int level;
    public Image candado;
    public Text texto;
    private string levelString;

	// Use this for initialization
	void Start () {
        if (PlayerPrefs.HasKey("levelhira"))
        {
            GlobalVariables.levelUnlockHira = PlayerPrefs.GetInt("levelhira", GlobalVariables.levelUnlockHira);
        }
        if (GlobalVariables.levelUnlockHira >= level)
        {
            LevelUnlocked();
        }else
        {
            LevelLocked();
        }
	}


    void LevelLocked() {
        GetComponent<Button>().interactable = false;
        candado.enabled = true;
        texto.enabled = false;
    }

    void LevelUnlocked(){
        GetComponent<Button>().interactable = true;
        candado.enabled = false;
        texto.enabled = true;
    }
	
}
