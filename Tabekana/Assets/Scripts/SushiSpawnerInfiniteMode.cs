using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiSpawnerInfiniteMode : MonoBehaviour {

	public GameObject sushi;                			// The enemy prefab to be spawned.
	public float spawnTime = 1f;            			// How long between each spawn.
	public Transform[] spawnPoints;         			// An array of the spawn points this enemy can spawn from.
	public string simpleHSprite;						//Simple hiragana sushi sprites for it's child RandomSushi script
	public string composedHSprite;						//Composed hiragana sushi sprites for it's child RandomSushi script
	public string simpleKSprite;						//Simple katakana sushi sprites for it's child RandomSushi script
	public string composedKSprite;						//Composed katakana sushi sprites for it's child RandomSushi script

	private int level;									//The current level for it's child RandomSushi script
	private int spawnedSushi = 0;						//To have a counter of the spawned sushi
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		GlobalVariables.maxScore = PlayerPrefs.GetInt("maxScore", GlobalVariables.maxScore);	// Recover the global variable (despite the fact that the user closed the app last time)
		Spawn();
		//InvokeRepeating ("Spawn", spawnTime, spawnTime); 
	}


	void Spawn (){
		CancelInvoke ();
		if (spawnTime - (GlobalVariables.score * 0.001) > 1) {
			spawnTime = spawnTime - (float)(GlobalVariables.score * 0.001);
		}
		InvokeRepeating ("Spawn", spawnTime, spawnTime);

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		GameObject go = (GameObject) Instantiate (sushi, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		//Make the counter count the spawned sushi
		spawnedSushi++;


		//Get reference of it's RandomSushi script
		RandomSushiInfinite comp = go.GetComponent<RandomSushiInfinite>();

		// Find a random index between zero and one ('two' is exclusive).
		// If spawnKana == 0 -> Hiragana
		// If spawnKana == 1 -> Katakana
		int spawnKana = Random.Range (0, 2);

		//Pass along the needed arguments for making it work depending on the actual level
		if(spawnKana == 0){
			comp.simple = simpleHSprite;
			comp.composed = composedHSprite;
			comp.level = PlayerPrefs.GetInt("levelhira");	// To create a random level between 1 and the last level unlocked.
			//print("Level Hira" + comp.level);
		} else if(spawnKana == 1){
			comp.simple = simpleKSprite;
			comp.composed = composedKSprite;
			comp.level = PlayerPrefs.GetInt("levelkata");
			//print("Level Kata" + comp.level);
		}
	}
}
