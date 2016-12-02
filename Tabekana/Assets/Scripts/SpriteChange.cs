using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpriteChange : MonoBehaviour {
	public LevelInf codigo;
	public GameObject nivel;
	public Image imagen;
	// Use this for initialization
	void Start () {
		nivel = GameObject.Find ("sushis");
		codigo=nivel.GetComponent<LevelInf>();
		imagen=gameObject.GetComponent<Image>();
		imagen.sprite = codigo.uno;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
