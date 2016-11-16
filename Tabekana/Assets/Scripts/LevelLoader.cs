using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	//Load the level with the name given as the string argument
	public void loadLevel(string sceneName){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
}
