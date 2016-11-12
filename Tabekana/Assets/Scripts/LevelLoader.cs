using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public void loadLevel(string sceneName){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
}
