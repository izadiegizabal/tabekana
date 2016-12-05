using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeSushi3: MonoBehaviour {
	public LevelInf codigo;
	public GameObject sushis;
	public Image imagen;
	// Use this for initialization
	void Start () {
		sushis = GameObject.Find ("sushis");
		codigo=sushis.GetComponent<LevelInf>();
		imagen=gameObject.GetComponent<Image>();
		imagen.sprite = codigo.c;
	}

	// Update is called once per frame
	void Update () {

	}
}