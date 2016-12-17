
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeSushi2: MonoBehaviour {
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
			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.b;

			}
			if (d==2){
				//Lesson 2
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.g;
			}
			if (d==3) {
				//Lesson 3
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.l;
			}
			if (d==4) {
				//Lesson 4
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.q;
			}
			if (d==5) {
				//Lesson 5
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.v;
			}
			if (d==6) {
				//Lesson 6
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.aa;
			}
			if (d==7) {
				//Lesson 7
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.fa;
			}
			if (d==8) {
				//Lesson 8
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ka;
			}
			if (d==9) {
				//Lesson 9
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.na;
			}
			if (d==10) {
				//Lesson 10
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.sa;
			}
			if (d==11) {
				//Lesson 11
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.va;
			}
			if (d==12) {
				//Lesson 12
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ab;
			}
			if (d==13) {
				//Lesson 13
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.fb;
			}
			if (d==14) {
				//Lesson 14
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.kb;
			}
			if (d==15) {
				//Lesson 15
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.pb;
			}

		}
		if (u.Equals('k')) {
			//Katakana
			if (d==1){
				//Lesson 1
				//m_tittletex="Lesson 1";
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.b;

			}
			if (d==2){
				//Lesson 2
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.g;
			}
			if (d==3) {
				//Lesson 3
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.l;
			}
			if (d==4) {
				//Lesson 4
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.q;
			}
			if (d==5) {
				//Lesson 5
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.v;
			}
			if (d==6) {
				//Lesson 6
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.aa;
			}
			if (d==7) {
				//Lesson 7
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.fa;
			}
			if (d==8) {
				//Lesson 8
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ka;
			}
			if (d==9) {
				//Lesson 9
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.na;
			}
			if (d==10) {
				//Lesson 10
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.sa;
			}
			if (d==11) {
				//Lesson 11
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.va;
			}
			if (d==12) {
				//Lesson 12
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ab;
			}
			if (d==13) {
				//Lesson 13
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.fb;
			}
			if (d==14) {
				//Lesson 14
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.kb;
			}
			if (d==15) {
				//Lesson 15
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.pb;
			}

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
