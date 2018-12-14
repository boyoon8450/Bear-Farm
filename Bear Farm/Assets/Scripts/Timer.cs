using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    int startTime=30;
    float currentTime;

	// Use this for initialization
	void Start () {
        //startTime = Time.time;
        currentTime = startTime;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //float t = Time.time - startTime;
        currentTime -= 1 * Time.deltaTime;
        //print(currentTime);
        timerText.text = "Time : "+((int)currentTime).ToString();

        if(currentTime <=0)
        {
            currentTime = 0;
        }

	}
}
