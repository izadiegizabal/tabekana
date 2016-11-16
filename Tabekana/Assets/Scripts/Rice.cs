using UnityEngine;
using System.Collections;

public class Rice : MonoBehaviour {

	private SpriteRenderer spriteRenderer;
	private Color start;
	private Color end;
	private float t = 0.0f;

	// Use this for initialization
	void Start () {
		//We get the SpriteRenderer
		spriteRenderer = GetComponent<SpriteRenderer> ();
		//We get the actual color of it
		start = spriteRenderer.color;
		//We define the end color, that will be the same but with 0% opacity
		end = new Color (start.r, start.g, start.b, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;

		//We gradually change color
		GetComponent<Renderer>().material.color = Color.Lerp (start, end, t + t/2);

		//And finally, when it's transparent we destroy it
		if(GetComponent<Renderer>().material.color.a <= 0.0){
			Destroy (gameObject);
		}
	}
}
