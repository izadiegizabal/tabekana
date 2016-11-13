using UnityEngine;
using System.Collections;

public class SushiSpawner : MonoBehaviour {

	public GameObject sushi;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	public int maxSushi = 10;
	public string simpleSprite;
	public string composedSprite;
	public int level = 1;

	private int spawnedSushi = 0;
	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		Spawn();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		// If the player has no health left...
		if(spawnedSushi >= maxSushi)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		GameObject go = (GameObject) Instantiate (sushi, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		spawnedSushi++;
		RandomSushi comp = go.GetComponent<RandomSushi>();
		comp.simple = simpleSprite;
		comp.composed = composedSprite;
		comp.level = this.level;
	}
}
