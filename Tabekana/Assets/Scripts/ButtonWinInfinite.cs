using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonWinInfinite : MonoBehaviour
{

    //public static int releasedLevelStatic = GlobalVariables.levelUnlockHira;

    void Awake()
    {
        //GlobalVariables.score = 0;//si no va, borra esto
        GlobalVariables.array3Characters = new string[3] { "_", "", "" };
        GlobalVariables.inputArrayChanged = false;
        GlobalVariables.spawnedSushi.Clear();
        GlobalVariables.launchPermission = false;
        GlobalVariables.destroyedSushi = 0;

    }


    public void ButtonMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    

    public void ButtonRepeat()
    {
        SceneManager.LoadScene("InfiniteMode", LoadSceneMode.Single);
    }

    public void ButtonLessons()
    {
            SceneManager.LoadScene("LessonChooser", LoadSceneMode.Single);
    }

}
