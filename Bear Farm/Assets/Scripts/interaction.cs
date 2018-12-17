using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour {

    public bool gazed_at;
    public string bear_name; //곰이름 받아옴
    public string obj_name; //cake 등의 오브젝트

    GameObject interact_obj; //cake 등의 오브젝트
   // public int interaction; //interacton rate


    public int interaction_count; //밤낮 바뀌는거 때문에 5회 채우면 바뀜

    GameObject bear;
    bear_move bear_move;

    public GameObject DayNightManager;
    daynightchange daynightchange;

    AudioSource sound;
    public AudioClip intearct_sound;

    GameObject Data;


    // Use this for initialization
    void Start () {
        daynightchange = DayNightManager.GetComponent<daynightchange>();
        interaction_count = 0;
        sound = gameObject.GetComponent<AudioSource>();

        Data = GameObject.Find("BearManager");
    }
	
	// Update is called once per frame
	void Update () {

        if(interaction_count == 5)
        {
            interaction_count = 0;
            daynightchange.changetoNight();
        }
        

        if (gazed_at)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //B곰 //기본
                if (string.Compare(bear_name, "EvilbearB") == 0)
                {
                    DataManager.totalIntimacy  += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                //A곰
                else if (string.Compare(bear_name, "EvilbearA") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearC") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearD") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearE") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearF") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearG") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearH") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearI") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearJ") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearK") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearL") == 0)
                {
                    DataManager.totalIntimacy += 10;
                    Data.GetComponent<checkBear>().canGetBear(0, DataManager.totalIntimacy);
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    sound.PlayOneShot(intearct_sound, 0.4f);
                    interaction_count++;
                }
            }
        }
	}
}
