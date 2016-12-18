using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenSoundEffect : MonoBehaviour {

	public AudioClip[] movementSounds;

	public void Start(){
		GetComponent<AudioSource>().clip = movementSounds[Random.Range(0,movementSounds.Length)];
		GetComponent<AudioSource>().Play();
	}
}
