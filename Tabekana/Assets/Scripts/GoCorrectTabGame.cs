using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MaterialUI;

public class GoCorrectTabGame : MonoBehaviour {
	void Start(){
		if (GlobalVariables.actGameLvl != null && GlobalVariables.actGameLvl.Split (new[] { " " }, System.StringSplitOptions.None) [0] == "h") {
			GetComponent<TabView>().SetPage(0, false);
		} else if(GlobalVariables.actGameLvl != null && GlobalVariables.actGameLvl.Split (new[] { " " }, System.StringSplitOptions.None) [0] == "k") {
			GetComponent<TabView>().SetPage(1, false);
		}
	}
}
