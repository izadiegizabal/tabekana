﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MaterialUI;

public class GoCorrectTab : MonoBehaviour {

	private string hirakata;
	void Start(){
		if(GlobalVariables.actLearnLvl != null)
			hirakata = GlobalVariables.actLearnLvl.Split (new[] { " " }, System.StringSplitOptions.None) [0];
		if (GlobalVariables.actLearnLvl != null && GlobalVariables.actLearnLvl.Split (new[] { " " }, System.StringSplitOptions.None) [0] == "h") {
			GetComponent<TabView>().SetPage(0, false);
		} else if(GlobalVariables.actLearnLvl != null && GlobalVariables.actLearnLvl.Split (new[] { " " }, System.StringSplitOptions.None) [0] == "k") {
			GetComponent<TabView>().SetPage(1, false);
		}
	}
}
