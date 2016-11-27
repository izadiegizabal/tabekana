using UnityEngine;
using System.Collections;

public class ShurikenToSushi : Physics2DObject {

	[Header("Movement")]
	// Speed used to move towards the player
	public float speed = 1f;

	//THE target
	public string target;

	// Used to decide if the object will look at the player while pursuing him
	public bool lookAtPlayer = false;

	// The direction that will face the player
	public Enums.Directions useSide = Enums.Directions.Up;

	private Transform playerTransform;

	// FixedUpdate is called once per frame
	public void launch () {
		// Find the player in the scene and store a reference for later use
		playerTransform = GameObject.Find(target).transform;
			
		//Move towards the player
		rigidbody2D.MovePosition(Vector2.Lerp(transform.position, playerTransform.position, Time.fixedDeltaTime * speed));

		//look towards the player
		if(lookAtPlayer) {
			Utils.SetAxisTowards(useSide, transform, playerTransform.position - transform.position);
		}
	}
}