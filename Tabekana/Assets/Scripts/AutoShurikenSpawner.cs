using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
public class AutoShurikenSpawner : MonoBehaviour
{
	[Header("Object creation")]

	// The object to spawn
	// WARNING: take if from the Project panel, NOT the Scene/Hierarchy!
	public GameObject prefabToSpawn;

	[Header("Other options")]

	private Transform trans;
	private string target;
	void Start () {
		trans = GetComponent<Transform>();
	}

	void Update(){
		
		if(GlobalVariables.inputArrayChanged){
			target  = FindTarget.findTarget ();
			if (target != null && GlobalVariables.launchPermission) {
				SpawnObject ();
			}
		}
	}
	
	// This will spawn an object, and then wait until it can launch again, then spawn another...
	void SpawnObject () {
		// Generate the new object
		GameObject newObject = Instantiate<GameObject> (prefabToSpawn);
		newObject.transform.position = new Vector2 (this.transform.position.x, this.transform.position.y);
		newObject.transform.SetParent (trans);

		//Disable new spawn
		GlobalVariables.launchPermission = false;
		//Remove target from spawned sushi
		GlobalVariables.spawnedSushi.Remove (target);

		//Launch the shuriken
		ShurikenToSushi test = newObject.GetComponent<ShurikenToSushi>();
		test.target = target;
		test.launch ();

		//Target back to null for next launch
		target = null;
	}
}
