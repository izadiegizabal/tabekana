using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputAnimation : MonoBehaviour {

	void GoBackToIdle() {
		GetComponent<Animator>().SetInteger ("AnimState", 0);
	}
}
