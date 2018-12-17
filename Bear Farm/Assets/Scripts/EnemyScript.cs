using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private Transform player;
    int MoveSpeed = 2;
    int MaxDist = 20;
    int MinDist = 1;

    public Transform[] spawnPoints;

    Animator enemyAnim;
    public bool isCreated;

    //public GameObject enemyPrefab;
    int spawnPointIndex;
    //public int score = 0;
    public Text scoreText;
    private int hitpoints = 0;
    bool isDead = false;
    GameObject bullet;

    GameObject dataMG;

    //인아 day-night 바뀌는 코드 때문
    public GameObject DayNightManager;
    daynightchange daynightchange;

    //인아 sound effect 때문
    AudioSource sound;
    public AudioClip collide;
    public GameObject Managers;
    GameObject enemy;
    public GameObject enemyOriginal;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        bullet = GameObject.Find("Bullet");
        dataMG = GameObject.Find("BearManager");
        //인아 day-night 바뀌는 코드 때문
        daynightchange = DayNightManager.GetComponent<daynightchange>();
        //소리
        sound = Managers.GetComponent<AudioSource>();
        //isCreated = false;
        enemyOriginal = GameObject.Find("EnemyOriginal");
        
    }

    void Awake()
    {


    //    if (daynightchange.check_day == false)
    //        GameObject.Find("Enemy").SetActive(true);
    }

    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) > MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) <= MinDist)
            {
                sound.PlayOneShot(collide, 0.2f);

                DataManager.totalIntimacy -= 10;
                NewSpawn();

                TakeDamage();
            }
        }

        if (daynightchange.check_day == true)
        {
            if (GameObject.Find("EnemyOriginal(Clone)")) { 
            enemy = GameObject.Find("EnemyOriginal(Clone)");
            if(enemy.activeSelf==true)
            {
                //enemy.SetActive(false);

                Destroy(enemy);
            }
        }
        }
        // NewSpawn();

    }

    public void TakeDamage()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);

    }

    public void NewSpawn()
    {
        //if (!isCreated && !daynightchange.check_day)
            if (!daynightchange.check_day)
            {
            gameObject.SetActive(true);
            Debug.Log(gameObject.name);
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyOriginal, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bullet") //&& !isDead)
        {
         //   hitpoints++;
        //    isDead = true;
        //    if (hitpoints == 1)
            {
                Debug.Log(ScoreScript.score);
                Debug.Log(gameObject.name+" "+ScoreScript.score);
                ScoreScript.score = ScoreScript.score + 10;
                scoreText.text = "Score : " + ScoreScript.score.ToString();
                dataMG.GetComponent<checkBear>().canGetBear(1, ScoreScript.score);
                Debug.Log("Score "+ ScoreScript.score);
                NewSpawn();

                TakeDamage();
            }
        }
    }
}