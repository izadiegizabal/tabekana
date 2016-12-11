using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class levelCleared : MonoBehaviour
{

    public Text txtlvl=null;
    public Text txtlesson = null;

    void Start()
    {
        int lvlnum = int.Parse(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1]);
        txtlvl.text = "Level " + lvlnum + " Cleared";
        lvlnum = lvlnum + 1;
        txtlesson.text = "Lesson " + lvlnum;
    }


}