using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text timerText;
    int startTime=30;
    float currentTime;

    //인아 day-night 바뀌는 코드 때문
    public GameObject DayNightManager;
    daynightchange daynightchange;

	// Use this for initialization
	void Start () {
        //startTime = Time.time;
        currentTime = startTime;

        //인아 day-night 바뀌는 코드 때문
        daynightchange = DayNightManager.GetComponent<daynightchange>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        //인아 
        if (daynightchange.check_day == false) {
            //float t = Time.time - startTime;
            currentTime -= 1 * Time.deltaTime;
            //print(currentTime);
            timerText.text = "Time : "+((int)currentTime).ToString();
            if (currentTime <=0)
            {
                currentTime = 0;
                //인아 day-night 바뀌는 코드 때문
                daynightchange.changetoDay();
                currentTime = 30;
            }
        }

    }
}
