using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour {

    public bool gazed_at;
    public string bear_name; //곰이름 받아옴
    public string obj_name; //cake 등의 오브젝트

    GameObject interact_obj; //cake 등의 오브젝트
    public int interaction_B; //eveilbearB의 interacton rate
    public int interaction_A; //eveilbearA의 interacton rate
    public int interaction_C; //eveilbearA의 interacton rate
    public int interaction_D; //eveilbearA의 interacton rate
    public int interaction_E; //eveilbearA의 interacton rate
    public int interaction_F; //eveilbearA의 interacton rate
    public int interaction_G; //eveilbearA의 interacton rate
    public int interaction_H; //eveilbearA의 interacton rate
    public int interaction_I; //eveilbearA의 interacton rate
    public int interaction_J; //eveilbearA의 interacton rate
    public int interaction_K; //eveilbearA의 interacton rate
    public int interaction_L; //eveilbearA의 interacton rate

    public int interaction_count; //밤낮 바뀌는거 때문에 5회 채우면 바뀜

    GameObject bear;
    bear_move bear_move;

    public GameObject DayNightManager;
    daynightchange daynightchange;

    // Use this for initialization
    void Start () {
        daynightchange = DayNightManager.GetComponent<daynightchange>();
        interaction_count = 0;
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
            if (Input.GetKeyDown("space"))
            {
                //B곰 //기본
                if (string.Compare(bear_name, "EvilbearB") == 0)
                {
                    interaction_B += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                //A곰
                else if (string.Compare(bear_name, "EvilbearA") == 0)
                {
                    interaction_A += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearC") == 0)
                {
                    interaction_C += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearD") == 0)
                {
                    interaction_D += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearE") == 0)
                {
                    interaction_E += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearF") == 0)
                {
                    interaction_F += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearG") == 0)
                {
                    interaction_G += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearH") == 0)
                {
                    interaction_H += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearI") == 0)
                {
                    interaction_I += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearJ") == 0)
                {
                    interaction_J += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearK") == 0)
                {
                    interaction_K += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
                else if (string.Compare(bear_name, "EvilbearL") == 0)
                {
                    interaction_L += 10;
                    interact_obj = GameObject.Find(obj_name);
                    interact_obj.SetActive(false);
                    gazed_at = false;

                    bear = GameObject.Find(bear_name);
                    bear_move = bear.GetComponent<bear_move>();
                    bear_move.desire = false;
                    interaction_count++;
                }
            }
        }
	}
}
