using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InfiniteCleared : MonoBehaviour {

    public Text txtscore = null;
    public Text txtmaxscore = null;

    // Use this for initialization
    void Start () {

        txtscore.text = "" + GlobalVariables.score;
        txtmaxscore.text = "" + GlobalVariables.maxScore;
    }
	
}
