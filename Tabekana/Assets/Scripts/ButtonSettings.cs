using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonSettings : MonoBehaviour {

    public static int releasedLevelStatic = GlobalVariables.levelUnlockHira;
    public int releasedLevel;
    public string nextLevel;


    void Awake() {


        if (GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[0] == "h")
        {
            GlobalVariables.levelUnlockHira++;
            PlayerPrefs.SetInt("levelhira", GlobalVariables.levelUnlockHira);
        }else{
            GlobalVariables.levelUnlockKata++;
            PlayerPrefs.SetInt("levelkata", GlobalVariables.levelUnlockKata);
        }
       
    }


    public void ButtonMenu()
    {
        SceneManager.LoadScene("GameLevelChooser");
    }
}
