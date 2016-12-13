
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class ChangeSushi3: MonoBehaviour {
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
				imagen.sprite = codigo.c;

			}
			if (d==2){
				//Lesson 2
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.h;
			}
			if (d==3) {
				//Lesson 3
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.m;
			}
			if (d==4) {
				//Lesson 4
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.r;
			}
			if (d==5) {
				//Lesson 5
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.w;
			}
			if (d==6) {
				//Lesson 6
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ba;
			}
			if (d==7) {
				//Lesson 7
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ga;
			}
			if (d==8) {
				//Lesson 8
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.la;
			}
			if (d==9) {
				//Lesson 9
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.oa;
			}
			if (d==10) {
				//Lesson 10
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ta;
			}
			if (d==11) {
				//Lesson 11
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.wa;
			}
			if (d==12) {
				//Lesson 12
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.bb;
			}
			if (d==13) {
				//Lesson 13
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.gb;
			}
			if (d==14) {
				//Lesson 14
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.lb;
			}
			if (d==15) {
				//Lesson 15
				sushis = GameObject.Find ("sushis");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.qb;
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
				imagen.sprite = codigo.c;

			}
			if (d==2){
				//Lesson 2
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.h;
			}
			if (d==3) {
				//Lesson 3
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.m;
			}
			if (d==4) {
				//Lesson 4
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.r;
			}
			if (d==5) {
				//Lesson 5
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.w;
			}
			if (d==6) {
				//Lesson 6
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ba;
			}
			if (d==7) {
				//Lesson 7
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ga;
			}
			if (d==8) {
				//Lesson 8
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.la;
			}
			if (d==9) {
				//Lesson 9
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.oa;
			}
			if (d==10) {
				//Lesson 10
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.ta;
			}
			if (d==11) {
				//Lesson 11
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.wa;
			}
			if (d==12) {
				//Lesson 12
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.bb;
			}
			if (d==13) {
				//Lesson 13
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.gb;
			}
			if (d==14) {
				//Lesson 14
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.lb;
			}
			if (d==15) {
				//Lesson 15
				sushis = GameObject.Find ("sushisk");
				codigo=sushis.GetComponent<LevelInf>();
				imagen=gameObject.GetComponent<Image>();
				imagen.sprite = codigo.qb;
			}

		}
	}

	// Update is called once per frame
	void Update () {

	}
}
