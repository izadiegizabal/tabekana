using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	//We add the prefab that we'll be using as the parts that will appear in the explossion
	public Rice rice;
	//The number of parts that'll appear
	public int totalParts = 10;


	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

	//When trigger or collission change to appropiate animation that uses the Destroy method
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Shuriken") {
			animator.SetInteger ("AnimState", 1);
		}

	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Shuriken") {
			animator.SetInteger ("AnimState", 1);
		}

	}


	//When called
	public void Destroy(){

		//Destroy the object
		Destroy (gameObject);

		var t = transform;

		//Create "totalParts" "rice pieces" in random directions and w/ random forces
		for (int i = 0; i < totalParts; i++) {
			Rice clone = Instantiate(rice, t.position, Quaternion.identity) as Rice;
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (Random.Range (-100, 100)));
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(75, 300));
		}

	}
}
