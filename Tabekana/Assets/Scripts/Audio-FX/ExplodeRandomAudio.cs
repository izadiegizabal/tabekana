using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeRandomAudio : MonoBehaviour {

	public AudioClip[] explosionClips;

	public void RandomExplosionSound(){
		GetComponent<AudioSource>().clip = explosionClips[Random.Range(0,explosionClips.Length)];
		GetComponent<AudioSource>().Play();
	}
}
