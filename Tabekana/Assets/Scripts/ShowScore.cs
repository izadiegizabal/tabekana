using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour {

	private Text showScore;								// To show the score if the user get a score over than the global score

	// Use this for initialization
	void Start () {
		showScore = GetComponent<Text>();
		showScore.text = "Score: " + GlobalVariables.score;
	}
	
	// Update is called once per frame
	void Update () {
		showScore.text = "Score: " + GlobalVariables.score;
	}
}
