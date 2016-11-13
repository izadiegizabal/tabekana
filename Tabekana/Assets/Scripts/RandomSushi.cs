using UnityEngine;
using System.Collections;

public class RandomSushi : MonoBehaviour {

	public string simple;
	public string composed;
	public int level = 1;

	private Sprite[] sprites;
	private  int currentSprite;
	private int untilWhat;
	private int levelSushi = 5;
	// Use this for initialization

	void Start () {
		if (simple != null) {
			if (composed != null){
				Sprite[] simpleSushi = Resources.LoadAll<Sprite> (simple);
				Sprite [] composedSushi = Resources.LoadAll<Sprite> (composed);
				sprites = new Sprite[simpleSushi.Length + composedSushi.Length];
				System.Array.Copy(simpleSushi, sprites, simpleSushi.Length);
				System.Array.Copy(composedSushi, 0, sprites, simpleSushi.Length, composedSushi.Length);
			} else {
				sprites = Resources.LoadAll<Sprite> (simple);
			}
		}
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
				levelSushi = 3;
				break;
			case 9:
				untilWhat = 42;
				break;
			case 10:
				untilWhat = 45;
				levelSushi = 3;
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
		/////////////////////////////
			case 16:
				untilWhat = 76;
				levelSushi = 6;
				break;
			case 17:
				untilWhat = 82;
				levelSushi = 6;
				break;
			case 18:
				untilWhat = 88;
				levelSushi = 6;
				break;
			case 19:
				untilWhat = 94;
				levelSushi = 6;
				break;
			case 20:
				untilWhat = 97;
				levelSushi = 3;
				break;
			case 21:
				untilWhat = 100;
				levelSushi = 3;
				break;
			case 22:
				untilWhat = 103;
				levelSushi = 3;
				break;
			}

			if(Random.Range (0, 100) < 75)
				currentSprite = Random.Range (untilWhat-levelSushi+1, untilWhat+1);
			else
				currentSprite = Random.Range (0, untilWhat-levelSushi+1);

			GetComponent<SpriteRenderer> ().sprite = sprites[currentSprite];
		}

	// Update is called once per frame
	void Update () {

	}
}
