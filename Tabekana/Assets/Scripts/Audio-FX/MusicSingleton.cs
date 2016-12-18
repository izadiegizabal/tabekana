using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MusicSingleton : MonoBehaviour {
	private static string currentScene, previousScene;
	private static MusicSingleton instance = null;
	private static bool newScene = false;
	public static MusicSingleton Instance {
		get { return instance; }
	}

	void Awake(){

		if (instance != null && instance != this){
			if(instance.GetComponent<AudioSource>().clip != GetComponent<AudioSource>().clip){
				instance.GetComponent<AudioSource>().clip = GetComponent<AudioSource>().clip;
				instance.GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume;
				instance.GetComponent<AudioSource>().Play();
			}
			Destroy(this.gameObject);
			return;
		} 
		instance = this;
		GetComponent<AudioSource>().Play ();
		DontDestroyOnLoad(this.gameObject);
	}

	void OnLevelWasLoaded(){
		currentScene = SceneManager.GetActiveScene ().name;

		if (currentScene.Equals ("GameLevelChooser") || currentScene.Equals ("LessonChooser") || currentScene.Equals ("LevelInfo1") || currentScene.Equals ("LevelInfo")) {
			currentScene = "MainMenu";
		}

		if (SceneManager.GetActiveScene ().name.Equals ("InfiniteMode")) {
			instance.GetComponent<AudioSource> ().clip = Resources.Load ("samurai-sword") as AudioClip;
			instance.GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume;
			instance.GetComponent<AudioSource> ().Play ();
			previousScene = currentScene;
		} else if (SceneManager.GetActiveScene ().name.Equals ("LevelStaging")) {
			instance.GetComponent<AudioSource> ().clip = Resources.Load ("samurai-dance") as AudioClip;
			instance.GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume;
			instance.GetComponent<AudioSource> ().Play ();
			previousScene = currentScene;
		} else if (SceneManager.GetActiveScene ().name.Equals ("YouWin")) {
			instance.GetComponent<AudioSource> ().clip = Resources.Load ("ondo") as AudioClip;
			instance.GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume;
			instance.GetComponent<AudioSource> ().Play ();
			previousScene = currentScene;
		} else if(SceneManager.GetActiveScene ().name.Equals ("YouLose")){
			instance.GetComponent<AudioSource> ().clip = Resources.Load ("kanashimi-no-nakani") as AudioClip;
			instance.GetComponent<AudioSource> ().volume = GetComponent<AudioSource> ().volume;
			instance.GetComponent<AudioSource> ().Play ();
			previousScene = currentScene;
		} else if (previousScene != null && !previousScene.Equals("MainMenu")) {
			instance.GetComponent<AudioSource> ().clip = Resources.Load ("yurari-yurari") as AudioClip;
			instance.GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume;
			instance.GetComponent<AudioSource>().Play();
			previousScene = currentScene;
		}
	}
}

