using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Debug.Log("0 clicked");
            DataManager.totalIntimacy += 10;
            Debug.Log("total intimacy : " + DataManager.totalIntimacy);
            //checkBear.canGetBear(0,DataManager.totalIntimacy);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("1 clicked");
            DataManager.highScore += 10;
            Debug.Log("highScore : " + DataManager.highScore);
            //checkBear.canGetBear(1, DataManager.highScore);
        }
    }
}
