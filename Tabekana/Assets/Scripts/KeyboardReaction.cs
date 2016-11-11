using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyboardReaction : MonoBehaviour {

	public float time = 1f;

	private bool canCallFunction = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (canCallFunction && Input.GetMouseButtonDown (0)) {
			this.GetComponentInChildren<Text> ().fontSize = 120;
			this.GetComponentInChildren<Text> ().color = new Color (0, 0, 0, 0.45f);
			Wait(time);
		} else if(canCallFunction) {
			this.GetComponentInChildren<Text> ().fontSize = 72;
			this.GetComponentInChildren<Text> ().color = new Color (1, 1, 1, 1);
		}
	}

	IEnumerator Wait(float time) {
		canCallFunction = false;
		yield return new WaitForSeconds (time);
		canCallFunction = true;
	}
}
