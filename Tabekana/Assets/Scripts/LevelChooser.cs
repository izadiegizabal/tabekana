﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChooser : MonoBehaviour{
    // string level;

    public void leerClic(string level){
        // Guardo en la variable global el nivel
        //GlobalVariables.actLearnLvl = level;
		GlobalVariables.actGameLvl = level;
		SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);

    }
}