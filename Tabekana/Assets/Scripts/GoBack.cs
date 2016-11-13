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
		if (Application.platform == RuntimePlatform.Android) {
			if (Input.GetKey (KeyCode.Escape)) {
				SceneManager.LoadScene (sceneName, LoadSceneMode.Single);
				return;
			}
		}
	}
}
