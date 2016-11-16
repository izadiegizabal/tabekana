using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowInput : MonoBehaviour {

	private Text input;
	// Use this for initialization
	void Start () {
		input = GetComponentInChildren<Text>();
		GetComponentInChildren<Text>().fontSize = 50;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
