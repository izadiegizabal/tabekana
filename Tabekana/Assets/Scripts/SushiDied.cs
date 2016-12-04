using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SushiDied : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



	//Load the level with the name given as the string argument
	public void loadLevel(string sceneName){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}



	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Sushi") {
			StartCoroutine (waitAnimation(0.5f));

		}

	}

	IEnumerator waitAnimation(float sec){
		yield return new WaitForSeconds(sec);
		SceneManager.LoadScene("YouLose", LoadSceneMode.Single);
	}
}
