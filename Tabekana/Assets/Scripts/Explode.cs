using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	public Rice rice;
	public int totalParts = 10;


	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

	}

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


	public void Destroy(){
	
		Destroy (gameObject);

		var t = transform;

		for (int i = 0; i < totalParts; i++) {
			Rice clone = Instantiate(rice, t.position, Quaternion.identity) as Rice;
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (Random.Range (-100, 100)));
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(75, 300));
		}

	}
}
