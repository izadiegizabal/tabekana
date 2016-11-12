using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class AutoMove : Physics2DObject
{
	// These are the forces that will push the object every frame
	// don't forget they can be negative too!
	private Vector2  directionAndStrength;// = new Vector2(1f, 0f);
	public float strength = 1f;

	void Start(){
		directionAndStrength = new Vector2 ((float)Random.Range(-50, 50), strength);
	}

	//is the push relative or absolute to the world?
	public bool relative = true;

	
	// FixedUpdate is called once per frame
	void FixedUpdate ()
	{

		if(relative)
		{
			GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(directionAndStrength.x, directionAndStrength.y) * 2f);
		}
		else
		{
			GetComponent<Rigidbody2D>().AddForce(new Vector2(directionAndStrength.x, directionAndStrength.y) * 2f);
		}
	}
}
