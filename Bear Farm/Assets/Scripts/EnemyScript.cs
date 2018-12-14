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
    public float health = 50f;

    public Transform[] spawnPoints;

    Animator enemyAnim;
    bool isCreated;

    public GameObject enemyPrefab;
    int spawnPointIndex;
    public int score = 0;
    public Text scoreText;
    private int hitpoints = 1;

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
        Debug.Log("Take Damage " + gameObject.name);
    //    enemyAnim.SetBool("isDead", true);

    //    if (enemyAnim.GetBool("isDead") == true)
    //    {
            gameObject.SetActive(false);
            this.transform.parent.gameObject.SetActive(false);
    //    }

    }

    void NewSpawn()
    {
        if (!isCreated)
        {
            
            gameObject.SetActive(true);
            this.transform.parent.gameObject.SetActive(true);
            Debug.Log("spawn");
            spawnPointIndex = Random.Range(0, spawnPoints.Length);
            Debug.Log("spawn2");
            Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            Debug.Log("spawnfinish");
            isCreated = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            //  hitpoints--;

            //   if (hitpoints >= 0)
            //   {
            if (gameObject.name == "enemyController")
            {
                score = score + 50;

                Debug.Log("bullet" + gameObject.name);

                scoreText.text = "Score : " + score.ToString();
                TakeDamage();
                NewSpawn();


            }

                

        //    }
                

        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            //곰돌이 친밀도 하락
        }
    }
}