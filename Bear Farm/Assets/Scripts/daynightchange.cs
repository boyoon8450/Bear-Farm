using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daynightchange : MonoBehaviour {

    public bool check_day; //밤낮 여부 체크해주는 변수

    public Material night;
    public Material day;


    GameObject enemy;
    GameObject enemyOriginal;
    GameObject gun;
    GameObject score;

    AudioSource music;
    public AudioClip backday;
    public AudioClip backnight;

    GameObject Data;


	// Use this for initialization
	void Start () {
        check_day = true;

        //enemy = GameObject.Find("Enemy");
        //enemy.SetActive(false);

        enemyOriginal = GameObject.Find("EnemyOriginal");
        enemyOriginal.SetActive(false);

        gun = GameObject.Find("Flare Gun");
        gun.SetActive(false);

        score = GameObject.Find("ScoreCanvas");
        score.SetActive(false);

        music = gameObject.GetComponent<AudioSource>();
        music.clip = backday;
        music.volume = 0.4f;
        music.Play();


        day = RenderSettings.skybox;

        Data = GameObject.Find("DataManager");
        


    }

    // Update is called once per frame
    void Update () {
	}

    public void changetoDay()
    {
        check_day = true;
        RenderSettings.skybox = day;
        //enemy.SetActive(false);
        enemyOriginal.SetActive(false);
        gun.SetActive(false);
        score.SetActive(false);
        music.clip = backday;
        music.volume = 0.4f;
        music.Play();

        Data.GetComponent<createBear>().setBear();
    }

    public void changetoNight()
    {
        check_day = false;
        RenderSettings.skybox = night;
        //enemy.SetActive(true);
        enemyOriginal.SetActive(true);
        enemyOriginal.GetComponent<EnemyScript>().isCreated = false;
        enemyOriginal.GetComponent<EnemyScript>().NewSpawn();
        gun.SetActive(true);
        score.SetActive(true);
        music.clip = backnight;
        music.volume = 1;
        music.Play();
    }
}
