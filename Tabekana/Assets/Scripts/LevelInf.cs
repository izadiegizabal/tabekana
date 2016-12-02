using UnityEngine;
using System.Collections;
using UnityEngine.UI;




//[System.Serializable]
//public class AnimationSettings{//Settings for how your UI change during runtime
//	public enum OpenStyle{WhidtToHeight, HeightToWidth,HeightAndWidht}

//}

public class UISettings{
	//public Image textBox;//The box tha will contain the text
	//public Text text;//the message
	//añadir tamaños

	//public bool openning=false;

}
	
public class LevelInf : MonoBehaviour {
	public Sprite uno;
	public Sprite suno;

	 



	//public LevelInf codigo;
	//public GameObject nivel; 
	// Use this for initialization
	void Start () {
		
		suno=gameObject.GetComponent<LevelInf>().uno;



		//nivel = GameObject.Find ("sushis");
		//codigo = gameObject.GetComponent<LevelInf>().uno;

	}
	public Sprite Setuno(){
		return uno;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
