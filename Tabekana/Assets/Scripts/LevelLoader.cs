using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	//Load the level with the name given as the string argument
	public void loadLevel(string sceneName){
		SceneManager.LoadSceneAsync(sceneName);
		//SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		gameObject.AddComponent <AudioSource>();
		GetComponent<AudioSource> ().clip = Resources.Load ("button_click") as AudioClip;
		GetComponent<AudioSource>().volume = 1;
		GetComponent<AudioSource>().Play();
	}
}
