using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Transform player;
    int MoveSpeed = 1;
    int MaxDist = 25;
    int MinDist = 1;
    public float health = 50f;

    Animator enemyAnim;


    void Start()
    {
        enemyAnim = GameObject.Find("enemyController").GetComponent<Animator>();
    }

    void Update()
    {
        transform.LookAt(player);
        if (Vector3.Distance(transform.position, player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) <= MaxDist)
            {
                
            }
            else
            {
                transform.position = new Vector3(Random.Range(0, 0), 0, Random.Range(0, 0));
            }
        }
    }

    public void TakeDamage(float amount)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("dead");
            enemyAnim.SetBool("isDead", true);
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
            //곰돌이 친밀도 하락
        }
    }
}