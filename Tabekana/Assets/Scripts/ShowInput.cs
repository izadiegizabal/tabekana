using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowInput : MonoBehaviour {

	private Text input;
	// Use this for initialization
	void Start () {
		input = GetComponentInChildren<Text>();
		input.text = string.Join("", GlobalVariables.array3Characters);
	}
	
	// Update is called once per frame
	void Update () {
		input.text = string.Join("", GlobalVariables.array3Characters);
	}
}
