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
    bool isCreated;

    public GameObject enemyPrefab;
    int spawnPointIndex;
    public int score = 0;
    public Text scoreText;
    private int hitpoints = 0;
    bool isDead = false;
    GameObject bullet;

    //인아 day-night 바뀌는 코드 때문
    public GameObject DayNightManager;
    daynightchange daynightchange;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        bullet = GameObject.Find("Bullet");

        //인아 day-night 바뀌는 코드 때문
        daynightchange = DayNightManager.GetComponent<daynightchange>();
    }

    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) > MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) <= MinDist)
            {
                DataManager.totalIntimacy -= 10;
                NewSpawn();

                TakeDamage();
            }
        }

    }

    public void TakeDamage()
    {
        gameObject.SetActive(false);

    }

    public void NewSpawn()
    {
        if (!isCreated && daynightchange.check_day == false)
        {
            gameObject.SetActive(true);
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            
            Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            Debug.Log(spawnPointIndex);
            isCreated = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bullet" && !isDead)
        {
            hitpoints++;
            isDead = true;
            if (hitpoints == 1)
            {
                score = score + 30;
                scoreText.text = "Score : " + score.ToString();
                checkBear.canGetBear(1, score);

                NewSpawn();

                TakeDamage();
            }
        }
    }
}