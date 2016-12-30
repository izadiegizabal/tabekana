using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GlobalVariables.array3Characters = new string[3] { "_", "", "" };
        GlobalVariables.inputArrayChanged = false;
        GlobalVariables.spawnedSushi.Clear();
        GlobalVariables.launchPermission = false;
        GlobalVariables.destroyedSushi = 0;
		GlobalVariables.score = 0;
    }

    public void ButtonMenu()
    {
		SceneManager.LoadSceneAsync("GameLevelChooser");
        //SceneManager.LoadScene("GameLevelChooser");
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }

    public void ButtonRepeat()
    {
		SceneManager.LoadSceneAsync("LevelStaging");
        //SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }

    public void ButtonLesson()
    {

        string lvltipe;
        int lvlnum;

        if (GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[0] == "h")
        {
            lvltipe = "h ";
        }
        else
        {
            lvltipe = "k ";
        }
        lvlnum = int.Parse(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1]);
        GlobalVariables.actLearnLvl = lvltipe + lvlnum;

        if (lvlnum < 16)
        {
			SceneManager.LoadSceneAsync("LevelInfo1");
            //SceneManager.LoadScene("LevelInfo1", LoadSceneMode.Single);
        }
        else
        {
			SceneManager.LoadSceneAsync("LevelInfo");
            //SceneManager.LoadScene("LevelInfo", LoadSceneMode.Single);
        }
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }
}
