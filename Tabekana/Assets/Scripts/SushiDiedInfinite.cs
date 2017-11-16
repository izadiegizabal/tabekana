using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SushiDiedInfinite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Load the level with the name given as the string argument
	public void loadLevel(string sceneName){
		SceneManager.LoadSceneAsync(sceneName);
		//SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}



	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Sushi") {
			StartCoroutine (waitAnimation(0.5f));

		}

	}

	IEnumerator waitAnimation(float sec){
		yield return new WaitForSeconds(sec);
		if(GlobalVariables.score == GlobalVariables.maxScore){
			SceneManager.LoadSceneAsync("WinInfinite");
			//SceneManager.LoadScene("WinInfinite", LoadSceneMode.Single);
		}
		else{
			SceneManager.LoadSceneAsync("LoseInfinite");
			//SceneManager.LoadScene("LoseInfinite", LoadSceneMode.Single);
		}
		GlobalVariables.destroyedSushi = 0;
	}
}
