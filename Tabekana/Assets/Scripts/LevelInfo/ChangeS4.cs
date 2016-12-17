using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeS4: MonoBehaviour {
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
				imagen.sprite = codigo.d;

			}
			if (d==17){
				//Lesson 2
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.u;
			}
			if (d==18) {
				//Lesson 3
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.p;
			}
			if (d==19) {
				//Lesson 4
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.v;
			}
			if (d==20) {
				//Lesson 5
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ha;
			}
			if (d==21) {
				//Lesson 6
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ha;
			}
			if (d==22) {
				//Lesson 7
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ha;
			}


		}

		if (u.Equals ('k')) {
			//Katakana
			if (d == 16) {
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.d;

			}
			if (d == 17) {
				//Lesson 2
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.u;
			}
			if (d == 18) {
				//Lesson 3
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.p;
			}
			if (d == 19) {
				//Lesson 4
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.v;
			}
			if (d == 20) {
				//Lesson 5
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.ha;
			}
			if (d == 21) {
				//Lesson 6
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.ha;
			}
			if (d == 22) {
				//Lesson 7
				sushis = GameObject.Find ("sushisk");
				codigo = sushis.GetComponent<LevelInf> ();
				imagen = gameObject.GetComponent<Image> ();
				imagen.sprite = codigo.ha;
			}

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
