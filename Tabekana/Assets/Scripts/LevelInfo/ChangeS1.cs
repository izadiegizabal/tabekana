using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeS1: MonoBehaviour {
	public LevelInf codigo;
	public GameObject sushis;
	public Image imagen;


	// Use this for initialization
	void Start () {
		String value = null;
		value = GlobalVariables.actLearnLvl;

		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		if (u.Equals('h')) {
			//Hiragana
			if (d==16){
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.a;

			}
			if (d==17){
				//Lesson 2
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.g;
			}
			if (d==18) {
				//Lesson 3
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.m;
			}
			if (d==19) {
				//Lesson 4
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.s;
			}
			if (d==20) {
				//Lesson 5
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.y;
			}
			if (d==21) {
				//Lesson 6
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ba;
			}
			if (d==22) {
				//Lesson 7
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ea;
			}


		}

		if (u.Equals('k')) {
			//Katakana
			if (d==16){
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.a;

			}
			if (d==17){
				//Lesson 2
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.g;
			}
			if (d==18) {
				//Lesson 3
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.m;
			}
			if (d==19) {
				//Lesson 4
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.s;
			}
			if (d==20) {
				//Lesson 5
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.y;
			}
			if (d==21) {
				//Lesson 6
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ba;
			}
			if (d==22) {
				//Lesson 7
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ea;
			}


		}
	}

	// Update is called once per frame
	void Update () {

	}
}
