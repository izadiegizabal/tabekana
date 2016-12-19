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
		AsyncOperation ao = SceneManager.LoadSceneAsync("GameLevelChooser");
        //SceneManager.LoadScene("GameLevelChooser");
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
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
		AsyncOperation ao = SceneManager.LoadSceneAsync("LevelStaging");
        //SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }

    public void ButtonRepeat(){
		AsyncOperation ao = SceneManager.LoadSceneAsync("LevelStaging");
        //SceneManager.LoadScene("LevelStaging", LoadSceneMode.Single);
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    }

    public void ButtonLesson(){

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
        lvlnum = lvlnum + 1;
        GlobalVariables.actLearnLvl = lvltipe + lvlnum;

        if (lvlnum < 16) {
			AsyncOperation ao = SceneManager.LoadSceneAsync("LevelInfo1");
            //SceneManager.LoadScene("LevelInfo1", LoadSceneMode.Single);
        }else{
			AsyncOperation ao = SceneManager.LoadSceneAsync("LevelInfo");
            //SceneManager.LoadScene("LevelInfo", LoadSceneMode.Single);
        }
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
    } 

}
