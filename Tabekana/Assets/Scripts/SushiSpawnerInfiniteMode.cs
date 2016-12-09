﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiSpawnerInfiniteMode : MonoBehaviour {

	public GameObject sushi;                			// The enemy prefab to be spawned.
	public float spawnTime = 3f;            			// How long between each spawn.
	public Transform[] spawnPoints;         			// An array of the spawn points this enemy can spawn from.
	public string simpleHSprite;						//Simple hiragana sushi sprites for it's child RandomSushi script
	public string composedHSprite;						//Composed hiragana sushi sprites for it's child RandomSushi script
	public string simpleKSprite;						//Simple katakana sushi sprites for it's child RandomSushi script
	public string composedKSprite;						//Composed katakana sushi sprites for it's child RandomSushi script

	private int level;									//The current level for it's child RandomSushi script
	private int spawnedSushi = 0;						//To have a counter of the spawned sushi
	void Start () {
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		Spawn();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn (){
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Find a random index between zero and one ('two' is exclusive).
		// If spawnKana == 0 -> Hiragana
		// If spawnKana == 1 -> Katakana
		int spawnKana = Random.Range (0, 2);


		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		GameObject go = (GameObject) Instantiate (sushi, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
		//Make the counter count the spawned sushi
		spawnedSushi++;
		if (GlobalVariables.score > GlobalVariables.maxScore) {
			GlobalVariables.maxScore = GlobalVariables.score;
			go.GetComponent<ShowScore> ();
		}

		//Get reference of it's RandomSushi script
		RandomSushi comp = go.GetComponent<RandomSushi>();

		//Pass along the needed arguments for making it work depending on the actual level
		if(spawnKana == 0){
			comp.simple = simpleHSprite;
			comp.composed = composedHSprite;
			comp.level = PlayerPrefs.GetInt("levelhira");	// To create a random level between 1 and the last level unlocked.
		} else{
			comp.simple = simpleKSprite;
			comp.composed = composedKSprite;
			comp.level = PlayerPrefs.GetInt("levelkata");
		}
	}
}
