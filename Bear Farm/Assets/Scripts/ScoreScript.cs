using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    static public int score=0;
    public Text scoreText;
    EnemyScript enemys;

    GameObject dataMG;

    // Use this for initialization
    void Start () {
        enemys = GameObject.Find("EnemyOriginal").GetComponent<EnemyScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}