using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SushiSpawner : MonoBehaviour {

	public GameObject sushi;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public int maxSushi = 10;				// The number of sushis that will be spawned
	public string simpleSprite;				//Simple sushi sprites for it's child RandomSushi script
	public string composedSprite;			//Composed sushi sprites for it's child RandomSushi script
	public int level = 1;					//The current level for it's child RandomSushi script

	private int spawnedSushi = 0;			//To have a counter of the spawned sushi
	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		Spawn();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	public void loadLevel(string sceneName){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}
	void Spawn ()
	{
		// If we've spawned the max amount of sushis
		if(spawnedSushi >= maxSushi)
		{
			loadLevel("YouWin");
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
		//Pass along the needed arguments for making it work
		comp.simple = simpleSprite;
		comp.composed = composedSprite;
		comp.level = level;
	}
}
