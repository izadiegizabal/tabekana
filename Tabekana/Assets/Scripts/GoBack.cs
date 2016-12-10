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
				GlobalVariables.array3Characters = new string [3] {"_", "", ""};
				GlobalVariables.inputArrayChanged = false;
				GlobalVariables.spawnedSushi.Clear();
				GlobalVariables.launchPermission = false;
				GlobalVariables.destroyedSushi = 0;
				GlobalVariables.score = 0;
				//Go to the specified scene (the previous one)
				SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
				return;
			}
		}
	}
}
