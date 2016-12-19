using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowMaxScore : MonoBehaviour {

	private Text showMaxScore;							// To show the maxScore if the user get a score over than the global score

	// Use this for initialization
	void Start () {
		showMaxScore = GetComponent<Text>();
		showMaxScore.text = GlobalVariables.maxScore.ToString();	// To show maxScore from the begining

		if (GlobalVariables.score > GlobalVariables.maxScore) {
			showMaxScore.text = GlobalVariables.maxScore.ToString();
			PlayerPrefs.SetInt("maxScore", GlobalVariables.maxScore);	// Save the global variable if the user close the app
		}

	}

	// Update is called once per frame
	void Update () {
		if (GlobalVariables.score > GlobalVariables.maxScore) {
			GlobalVariables.maxScore = GlobalVariables.score;
			showMaxScore.text = GlobalVariables.maxScore.ToString();
			PlayerPrefs.SetInt("maxScore", GlobalVariables.maxScore);	// Save the global variable if the user close the app
		}

	}
}