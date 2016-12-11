using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettings : MonoBehaviour {

    //public static int releasedLevelStatic = GlobalVariables.levelUnlockHira;

    void Awake() {
        string lvlunlockh = GlobalVariables.levelUnlockHira.ToString();
        string lvlunlockk = GlobalVariables.levelUnlockKata.ToString();

        GlobalVariables.array3Characters = new string[3] { "_", "", "" };
        GlobalVariables.inputArrayChanged = false;
        GlobalVariables.spawnedSushi.Clear();
        GlobalVariables.launchPermission = false;
        GlobalVariables.destroyedSushi = 0;

       

        if (GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[0] == "h" 
            && GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1].Equals(lvlunlockh)
            && GlobalVariables.levelUnlockHira<22)
        {
            GlobalVariables.levelUnlockHira++;
            PlayerPrefs.SetInt("levelhira", GlobalVariables.levelUnlockHira);

        }else if(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[0] == "k"
            && GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1].Equals(lvlunlockk)
            && GlobalVariables.levelUnlockKata<22)
            {

            GlobalVariables.levelUnlockKata++;
            PlayerPrefs.SetInt("levelkata", GlobalVariables.levelUnlockKata);
        }
       
    }


    public void ButtonMenu()
    {
        SceneManager.LoadScene("GameLevelChooser");
    }

    public void ButtonNext()
    {
         string lvltipe; 
         int  lvlnum;
        
       if(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[0] == "h")
        {
            lvltipe = "h ";
        }else{
            lvltipe = "k ";
        }
        lvlnum = int.Parse(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1]);
        lvlnum = lvlnum + 1;
        GlobalVariables.actGameLvl = lvltipe + lvlnum;
        SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
    }

    public void ButtonRepeat()
    {
        SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
    }

}
