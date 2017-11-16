using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class levelCleared : MonoBehaviour
{

    public Text txtlvl=null;
    public Text txtlesson = null;
    public GameObject menu;
    public GameObject next;
    public GameObject restart;
    public Image bg;

    void Start()
    {
		GlobalVariables.array3Characters = new string[3] { "_", "", "" };
		GlobalVariables.inputArrayChanged = false;
		GlobalVariables.spawnedSushi.Clear();
		GlobalVariables.launchPermission = false;
		GlobalVariables.destroyedSushi = 0;
		GlobalVariables.score = 0;

        //para el nivel 22, eliminar y centrar botones
        if (GlobalVariables.actGameLvl.Equals("h 22") || GlobalVariables.actGameLvl.Equals("k 22")){
            if (GlobalVariables.actGameLvl.Equals("h 22")){
                txtlvl.text = "Hiragana Cleared";
            }else{
                txtlvl.text = "Katakana Cleared";
            }

            next.SetActive(false);
            menu.transform.position = new Vector3(420, 420, 0);
            restart.transform.position = new Vector4(660, 420, 0);
        }
        else{
            int lvlnum = int.Parse(GlobalVariables.actGameLvl.Split(new[] { " " }, System.StringSplitOptions.None)[1]);
            txtlvl.text = "Level " + lvlnum + " Cleared";
            lvlnum = lvlnum + 1;
            txtlesson.text = "Lesson " + lvlnum;
        }
      
    }

}