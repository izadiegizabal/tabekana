using UnityEngine;
using System.Collections;

public class RandomSushi : MonoBehaviour {

	public Sprite[] sprites;
	public string resourceName;
	public int level = 1;

	private  int currentSprite;
	private int untilWhat;
	// Use this for initialization
	void Start () {
		if(resourceName != null){
			sprites = Resources.LoadAll<Sprite> (resourceName);

			switch(level){
			case 1:
				untilWhat = ;
				break;
			case 2:
			}








			currentSprite = Random.Range (0, untilWhat);

			GetComponent<SpriteRenderer> ().sprite = sprites[currentSprite];
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
