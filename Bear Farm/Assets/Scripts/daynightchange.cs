using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightchange : MonoBehaviour {

    public bool check_day; //밤낮 여부 체크해주는 변수

    public Material night;
    public Material day;


    GameObject enemy;
    GameObject gun;
    GameObject score;

    AudioSource music;
    public AudioClip backday;
    public AudioClip backnight;

	// Use this for initialization
	void Start () {
        check_day = true;

        enemy = GameObject.Find("Enemy");
        enemy.SetActive(false);

        gun = GameObject.Find("Flare Gun");
        gun.SetActive(false);

        score = GameObject.Find("ScoreCanvas");
        score.SetActive(false);

        music = gameObject.GetComponent<AudioSource>();
        music.clip = backday;
        music.volume = 0.4f;
        music.Play();


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
        gun.SetActive(false);
        score.SetActive(false);
        music.clip = backday;
        music.volume = 0.4f;
        music.Play();
    }

    public void changetoNight()
    {
        check_day = false;
        RenderSettings.skybox = night;
        enemy.SetActive(true);
        gun.SetActive(true);
        score.SetActive(true);
        //Debug.Log(enemy.name);
        music.clip = backnight;
        music.volume = 1;
        music.Play();
    }
}
