using UnityEngine;
using System.Collections;

public class ShurikenToSushi : Physics2DObject {

	[Header("Movement")]
	public string target;

	private Transform sushiTransform;

	void Start(){
		// Find the player in the scene and store a reference for later use
		sushiTransform = GameObject.Find(target).transform;
		sushiTransform.gameObject.name = "objective";
	}

	// FixedUpdate is called once per frame
	void FixedUpdate () {
		//Move towards the player
		rigidbody2D.MovePosition(Vector2.MoveTowards(transform.position, sushiTransform.position, 0.2f));
		GetComponent<Transform>().Rotate (0,0,1000*Time.deltaTime);;
	}
}