using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelChooser : MonoBehaviour{
    // string level;

    public void leerClic(string level){
        // Guardo en la variable global el nivel
        //GlobalVariables.actLearnLvl = level;
		GlobalVariables.actGameLvl = level;

		AsyncOperation ao = SceneManager.LoadSceneAsync("LevelStaging");
		//SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }
}