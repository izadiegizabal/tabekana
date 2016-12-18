using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectFX : MonoBehaviour {
	
	public void IncorrectSound(){
		GetComponent<AudioSource>().Play();
	}

}
