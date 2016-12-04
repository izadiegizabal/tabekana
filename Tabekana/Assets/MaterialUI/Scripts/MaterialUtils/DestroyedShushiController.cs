using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyedShushiController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalVariables.destroyedSushi == GlobalVariables.maxSushi){
			StartCoroutine (waitAnimation(0.5f));
		}
	}

	IEnumerator waitAnimation(float sec){
		yield return new WaitForSeconds(sec);
		//Load Winning Scene and return, reset destroyed sushi counter
		SceneManager.LoadScene("YouWin", LoadSceneMode.Single);
		GlobalVariables.destroyedSushi = 0;
	}
}
