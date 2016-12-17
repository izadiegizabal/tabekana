using UnityEngine;
using System.Collections;

public class FindTarget : MonoBehaviour {

	private static string target = null;
	private static bool correct = false;
	private static Animator animator;

	public static string findTarget(){
		animator = GameObject.Find("Input").GetComponent<Animator> ();

		//if it has a letter
		if (GlobalVariables.array3Characters [1].Equals("_")){
			//we go through the spawnedSushi list looking for coincidences
			foreach (string temp in GlobalVariables.spawnedSushi) {
				//if the lenght is correct and the fist letters are the same
				if (temp [0].ToString().Equals (GlobalVariables.array3Characters [0])) {
					if (temp.Length == 1) {
						//we select the target, inform that we've found it, reset the input, and exit
						target = temp;
						GlobalVariables.array3Characters = new string [3] { "_", "", "" };
						correct = true;
						GlobalVariables.launchPermission = true;
						animator.SetInteger ("AnimState", 2);
						break;
					} else {
						correct = true;
					}
				}
			}
			//if we don't find any target, it means that the user has writen the romaji wrong --> we reset the input array and target
			if (!correct) {
				animator.SetInteger ("AnimState", 1);
				GlobalVariables.array3Characters = new string[3] {"_", "", ""};
				target = null;
			}
			else{
				correct = false;
			}
			//if the fist two are inputs but the third one is "empty"
		} else if(GlobalVariables.array3Characters [2].Equals("_")) {
			//print ("no, también pasó por aquí");
			//we go through the spawnedSushi list looking for coincidences
			foreach (string temp in GlobalVariables.spawnedSushi) {
				//if the lenght is correct and the fist letters are the same
				if (temp [0].ToString().Equals(GlobalVariables.array3Characters [0])) {
					//and also the seconds
					if (temp [1].ToString().Equals(GlobalVariables.array3Characters [1])) {
						if (temp.Length == 2) {
							//we select the target, inform that we've found it, reset the input, and exit
							target = temp;
							GlobalVariables.array3Characters = new string [3] {"_", "", ""};
							correct = true;
							GlobalVariables.launchPermission = true;
							animator.SetInteger ("AnimState", 2);
							break;
						} else {
							correct = true;
						}
					}
				}
			}
			//if we don't find any target, it means that the user has writen the romaji wrong --> we reset the input array and target
			if (!correct) {
				animator.SetInteger ("AnimState", 1);
				GlobalVariables.array3Characters = new string[3] {"_", "", ""};
				target = null;
			}
			else{
				correct = false;
			}
			//in other cases, it will have three letters
		} else {
			//we go through the spawnedSushi list looking for coincidences
			foreach (string temp in GlobalVariables.spawnedSushi) {
				//if the lenght is correct and the fist letters are the same
				if (temp [0].ToString().Equals(GlobalVariables.array3Characters [0])) {
					//and also the seconds
					if (temp [1].ToString().Equals(GlobalVariables.array3Characters [1])) {
						//and the third ones
						if (temp [2].ToString().Equals (GlobalVariables.array3Characters [2])) {
							if (temp.Length == 3) {
								//we select the target, inform that we've found it, reset the input, and exit
								target = temp;
								GlobalVariables.array3Characters = new string [3] { "_", "", "" };
								correct = true;
								GlobalVariables.launchPermission = true;
								animator.SetInteger ("AnimState", 2);
								break;
							}  else {
								correct = true;
							} 
						}
					}
				}
			}
			//if we don't find any target, it means that the user has writen the romaji wrong --> we reset the input array and target
			if (!correct) {
				animator.SetInteger ("AnimState", 1);
				GlobalVariables.array3Characters = new string[3] {"_", "", ""};
				target = null;
			}
			else{
				correct = false;
			}
		}

		//we reset the variable that controls the change in the input
		GlobalVariables.inputArrayChanged = false;

		return target;
	}
}
