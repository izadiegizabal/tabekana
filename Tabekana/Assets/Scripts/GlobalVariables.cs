using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class GlobalVariables : object {

	//the current input
	public static string[] array3Characters = new string [3] {"_", "", ""};
	public static bool inputArrayChanged = false;

	//the sushis that are spawned and visible at the current time
	public static  List<string> spawnedSushi = new List<string> ();

	//to know if you can launch another shuriken
	public static bool launchPermission = false;

	//sushis per round and current amount
	public static int maxSushi = 25;
	public static int destroyedSushi = 0;

	//actual learn level
	public static string actLearnLvl = null;
	public static string actGameLvl = null;
}
