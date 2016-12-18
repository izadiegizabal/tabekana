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
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene("GameLevelChooser");
    }

    public void ButtonRepeat()
    {
        SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
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
            SceneManager.LoadScene("LevelInfo1", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("LevelInfo", LoadSceneMode.Single);
        }
    }
}
