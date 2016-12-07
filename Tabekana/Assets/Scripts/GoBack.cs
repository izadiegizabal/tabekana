using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour {

	public string sceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//If we are on Android
		if (Application.platform == RuntimePlatform.Android) {
			//And we press the back button
			if (Input.GetKey (KeyCode.Escape)) {
				//Reset actual levels
				GlobalVariables.actLearnLvl = null;
				GlobalVariables.actGameLvl = null;
				//Go to the specified scene (the previous one)
				SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
				return;
			}
		}
	}
}
