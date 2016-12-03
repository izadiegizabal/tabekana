using UnityEngine;
using System.Collections;

public class SushiSpawner : MonoBehaviour {

	public GameObject sushi;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public int maxSushi = 10;				// The number of sushis that will be spawned
	public string simpleHSprite;			//Simple hiragana sushi sprites for it's child RandomSushi script
	public string composedHSprite;			//Composed hiragana sushi sprites for it's child RandomSushi script
	public string simpleKSprite;			//Simple katakana sushi sprites for it's child RandomSushi script
	public string composedKSprite;			//Composed katakana sushi sprites for it's child RandomSushi script

	private int level;						//The current level for it's child RandomSushi script
	private int spawnedSushi = 0;			//To have a counter of the spawned sushi
	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		Spawn();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		// If we've spawned the max amount of sushis
		if(spawnedSushi >= maxSushi)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		GameObject go = (GameObject) Instantiate (sushi, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		//Make the counter count the spawned sushi
		spawnedSushi++;
		//Get reference of it's RandomSushi script
		RandomSushi comp = go.GetComponent<RandomSushi>();

		//Pass along the needed arguments for making it work depending on the actual level
		if (GlobalVariables.actGameLvl != null && GlobalVariables.actGameLvl.Split (new[] {" "}, System.StringSplitOptions.None) [0] == "h") {
			comp.simple = simpleHSprite;
			comp.composed = composedHSprite;
		} else {
			comp.simple = simpleKSprite;
			comp.composed = composedKSprite;
		}
		comp.level = int.Parse(GlobalVariables.actGameLvl.Split (new[] {" "}, System.StringSplitOptions.None) [1]);
	}
}
