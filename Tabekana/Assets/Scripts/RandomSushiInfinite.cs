﻿using UnityEngine;
using System.Collections;

public class RandomSushiInfinite : MonoBehaviour {

	//We add the sprites for the simple and composed sushi
	public string simple;
	public string composed;

	//We specify the level that we're in
	public int level = 1;

	//Array that will hold the possible sprites
	private Sprite[] sprites;
	//The sprite number that will be displayed
	private  int currentSprite;
	//Until what sprite do we have to take into the random pool
	private int untilWhat;

	void Start () {
		//If we have the simple sprites
		if (simple != null) {
			//and we also have the composed
			if (composed != null){
				//We lode both of them
				Sprite[] simpleSushi = Resources.LoadAll<Sprite> (simple);
				Sprite [] composedSushi = Resources.LoadAll<Sprite> (composed);

				//And we merge them into the sprites array
				sprites = new Sprite[simpleSushi.Length + composedSushi.Length];
				System.Array.Copy(simpleSushi, sprites, simpleSushi.Length);
				System.Array.Copy(composedSushi, 0, sprites, simpleSushi.Length, composedSushi.Length);

			} else {	//Otherwise
				
				//only load the simple sushi sprites
				sprites = Resources.LoadAll<Sprite> (simple);
			}
		}
		//Depending on the level change the untilWhat values
		switch(level){
			case 1:
				untilWhat = 4;
				break;
			case 2:
				untilWhat = 9;
				break;
			case 3:
				untilWhat = 14;
				break;
			case 4:
				untilWhat = 19;
				break;
			case 5:
				untilWhat = 24;
				break;
			case 6:
				untilWhat = 29;
				break;
			case 7:
				untilWhat = 34;
				break;
			case 8:
				untilWhat = 37;
				break;
			case 9:
				untilWhat = 42;
				break;
			case 10:
				untilWhat = 45;
				break;
			case 11:
				untilWhat = 50;
				break;
			case 12:
				untilWhat = 55;
				break;
			case 13:
				untilWhat = 60;
				break;
			case 14:
				untilWhat = 65;
				break;
			case 15:
				untilWhat = 70;
				break;
		////////////// With composed ones ///////////////
			case 16:
				untilWhat = 76;
				break;
			case 17:
				untilWhat = 82;
				break;
			case 18:
				untilWhat = 88;
				break;
			case 19:
				untilWhat = 94;
				break;
			case 20:
				untilWhat = 97;
				break;
			case 21:
				untilWhat = 100;
				break;
			case 22:
				untilWhat = 103;
				break;
		}

		//coose any of the ones bejore
		currentSprite = Random.Range (0, untilWhat+1);

		//Change the current sprite to the chosen one
		GetComponent<SpriteRenderer> ().sprite = sprites[Mathf.Abs(currentSprite)];
		//we change the name of the go
		name = ResourceNameRomaji.ResToRomaji (sprites[Mathf.Abs(currentSprite)].name);

		//we add the name of the sushi to the spawnedSushi list
		GlobalVariables.spawnedSushi.Add (name);
	}
}
