
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeSushi5: MonoBehaviour {
	public LevelInf codigo;
	public GameObject sushis;
	public Image imagen;


	// Use this for initialization
	void Start () {
		String value = "h 8";
		//en esta varibale cambiar por el metodo que lanza alba 

		Char delimiter = ' ';
		String[] substrings = value.Split(delimiter);
		string a = substrings [0];
		string b = substrings [1];
		char u = char.Parse (a);
		int d = int.Parse (b);

		if (u.Equals('h')) {
			//Hiragana
			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.e;

			}
			if (d==2){
				//Lesson 2
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.j;
			}
			if (d==3) {
				//Lesson 3
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.o;
			}
			if (d==4) {
				//Lesson 4
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.t;
			}
			if (d==5) {
				//Lesson 5
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.y;
			}
			if (d==6) {
				//Lesson 6
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.da;
			}
			if (d==7) {
				//Lesson 7
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ia;
			}
			if (d==8) {
				//Lesson 8
				//vacio
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.tb;
			}
			if (d==9) {
				//Lesson 9
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.qa;
			}
			if (d==10) {
				//Lesson 10
				//vacio
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.tb;
			}
			if (d==11) {
				//Lesson 11
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ya;
			}
			if (d==12) {
				//Lesson 12
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.db;
			}
			if (d==13) {
				//Lesson 13
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ib;
			}
			if (d==14) {
				//Lesson 14
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.nb;
			}
			if (d==15) {
				//Lesson 15
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.sb;
			}

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
