using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private Transform player;
    int MoveSpeed = 1;
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

    DataManager datamanager;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    void Update()
    {
        transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) > MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) <= MinDist)
            {
                //곰돌이 친밀도 하락
                //아니면 OnTriggerEnter에서 친밀도 하락 조절
            }
        }

    }

    public void TakeDamage()
    {
        gameObject.SetActive(false);

    }

    public void NewSpawn()
    {
        if (!isCreated)
        {
            gameObject.SetActive(true);
            spawnPointIndex = Random.Range(0, spawnPoints.Length - 5);

            Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
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
                score = score + 50;
                scoreText.text = "Score : " + score.ToString();

                NewSpawn();

                TakeDamage();
            }
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            //곰돌이 친밀도 하락
        }
    }
}