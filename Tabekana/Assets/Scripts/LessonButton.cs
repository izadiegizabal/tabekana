
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LessonButton : MonoBehaviour {

    public Text txtlesson = null;

    void Start () {
		if (GlobalVariables.actGameLvl != null) {
			int lvlnum = int.Parse (GlobalVariables.actGameLvl.Split (new[] { " " }, System.StringSplitOptions.None) [1]);
			txtlesson.text = "Lesson " + lvlnum;
		}
    }
	
}
