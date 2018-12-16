using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class musicManager : MonoBehaviour {

    GameObject DayNightManager;
    AudioSource bgm;
    Toggle t;
    

	// Use this for initialization
	void Start () {

        DayNightManager = GameObject.Find("DayNightManager");
        bgm = DayNightManager.GetComponent<AudioSource>();
        t = gameObject.GetComponent<Toggle>();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void valueChanged()
    {
        if (t.isOn)
        {
            bgm.mute = false;
        }
        else
        {
            bgm.mute = true;
        }
    }
}
