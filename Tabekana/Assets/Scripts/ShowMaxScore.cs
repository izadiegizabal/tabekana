using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowMaxScore : MonoBehaviour {

	private Text showMaxScore;							// To show the maxScore if the user get a score over than the global score

	// Use this for initialization
	void Start () {
		// Show maxScore
		showMaxScore = GetComponent<Text>();
		showMaxScore.text = "MaxScore: " + GlobalVariables.maxScore;
	}

	// Update is called once per frame
	void Update () {
		showMaxScore.text = "MaxScore: " + GlobalVariables.maxScore;
	}
}