using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyScript : MonoBehaviour
{
    private Transform player;
    int MoveSpeed = 1;
    int MaxDist = 25;
    int MinDist = 1;
    public float health = 50f;

    public Transform[] spawnPoints;

    Animator enemyAnim;
    bool isCreated;

    public GameObject enemyPrefab;
    int spawnPointIndex;
    public int score = 0;
    public Text scoreText;

    void Start()
    {
        enemyAnim = GameObject.Find("enemyController").GetComponent<Animator>();
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

    void TakeDamage()
    {
        Debug.Log("dead " + gameObject.name);
    //    enemyAnim.SetBool("isDead", true);

    //    if (enemyAnim.GetBool("isDead") == true)
    //    {
            Debug.Log("isDead true - setActive false");
            gameObject.SetActive(false);
    //    }

    }

    void NewSpawn()
    {
        if (!isCreated)
        {
            Debug.Log("spawn");
            gameObject.SetActive(true);
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            isCreated = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("checked!!!!!!" + gameObject.name);
            score = score + 50;
            scoreText.text = "Score : " + score.ToString();

            TakeDamage();
            NewSpawn();


        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            //곰돌이 친밀도 하락
        }
    }
}