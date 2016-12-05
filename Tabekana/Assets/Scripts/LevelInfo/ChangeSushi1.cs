
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSushi1: MonoBehaviour {
	public LevelInf codigo;
	public GameObject sushis;
	public Image imagen;
	// Use this for initialization
	void Start () {
		sushis = GameObject.Find ("sushis");
		codigo=sushis.GetComponent<LevelInf>();
		imagen=gameObject.GetComponent<Image>();
		imagen.sprite = codigo.a;
	}

	// Update is called once per frame
	void Update () {

	}
}
