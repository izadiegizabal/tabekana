using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelUnlockKatakana : MonoBehaviour
{

    public int level;
    public Image candado;
    public Text texto;
    private string levelString;

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("levelkata"))
        {
            GlobalVariables.levelUnlockKata = PlayerPrefs.GetInt("levelkata", GlobalVariables.levelUnlockKata);
        }

        if (GlobalVariables.levelUnlockKata >= level)
        {
            LevelUnlocked();
        }
        else
        {
            LevelLocked();
        }
    }

    void LevelLocked()
    {
        GetComponent<Button>().interactable = false;
        candado.enabled = true;
        texto.enabled = false;
    }

    void LevelUnlocked()
    {
        GetComponent<Button>().interactable = true;
        candado.enabled = false;
        texto.enabled = true;
    }

}