using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonWinInfinite : MonoBehaviour
{

    //public static int releasedLevelStatic = GlobalVariables.levelUnlockHira;

    void Awake(){
        GlobalVariables.array3Characters = new string[3] { "_", "", "" };
        GlobalVariables.inputArrayChanged = false;
        GlobalVariables.spawnedSushi.Clear();
        GlobalVariables.launchPermission = false;
        GlobalVariables.destroyedSushi = 0;
    }


    public void ButtonMenu()
    {
		AsyncOperation ao = SceneManager.LoadSceneAsync("MainMenu");
        //SceneManager.LoadScene("MainMenu");
		GlobalVariables.score = 0;
    }
    

    public void ButtonRepeat()
    {
		AsyncOperation ao = SceneManager.LoadSceneAsync("InfiniteMode");
        //SceneManager.LoadScene("InfiniteMode", LoadSceneMode.Single);
		GlobalVariables.score = 0;
    }

    public void ButtonLessons()
    {
		AsyncOperation ao = SceneManager.LoadSceneAsync("LessonChooser");
        //SceneManager.LoadScene("LessonChooser", LoadSceneMode.Single);
		GlobalVariables.score = 0;
    }

}
