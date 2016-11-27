using UnityEngine;
using System.Collections;

public static class GlobalVariables : object {

	//the current input
	public static string[] array3Characters = new string [3] {"_", "", ""};
	public static bool inputArrayChanged = false;

	//the sushis that are spawned and visible at the current time
	public static ArrayList spawnedSushi = new ArrayList ();

	//to know if you can launch another shuriken
	public static bool launchPermission = true;


	//actual learn level
	public static int actLearnLvl = -1;
}
