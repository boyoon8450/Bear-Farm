using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightchange : MonoBehaviour {

    public bool check_day; //밤낮 여부 체크해주는 변수

    public Material night;
    public Material day;


    GameObject enemy;


	// Use this for initialization
	void Start () {
        check_day = true;

        enemy = GameObject.Find("Enemy");
        enemy.SetActive(false);

        day = RenderSettings.skybox;


    }

    // Update is called once per frame
    void Update () {
	}

    public void changetoDay()
    {
        check_day = true;
        RenderSettings.skybox = day;
        enemy.SetActive(false);
    }

    public void changetoNight()
    {
        check_day = false;
        RenderSettings.skybox = night;
        enemy.SetActive(true);
        Debug.Log(enemy.name);
    }
}
