using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShurikenBar : MonoBehaviour {

	private float fillAmount;

	[SerializeField]
	private Image shurikenBar;

	// Use this for initialization
	void Start () {
		
	}

	void Update(){
		HandleBar ();
	}
	
	private void HandleBar () {
		fillAmount = Map(GlobalVariables.destroyedSushi,0,GlobalVariables.maxSushi,0,1);
		if (fillAmount != 1) {
			shurikenBar.fillAmount = fillAmount;
		} else {
			SceneManager.LoadScene("YouWin");
		}
	}

	private float Map(float value, float inMin, float inMax, float outMin, float outMax){
		return (value - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
	}
}
