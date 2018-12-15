using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createBear : MonoBehaviour {

    GameObject[] bears = new GameObject[10];

	// Use this for initialization
	void Start () {
        string name = "Evilbear";
        bears[0] = GameObject.Find(name + "B");
        bears[1] = GameObject.Find(name + "A");
        for(int i = 2; i < 10; i++)
        {
            bears[i] = GameObject.Find(name + (char)('A' + i));
        }
	}
	
	// Update is called once per frame
	void setBear () {
        for(int i = 0; i < 10; i++)
        {
            if(DataManager.haveBear[i] == 1)
            {
                bears[i].SetActive(true);
            }
            else
            {
                bears[i].SetActive(false);
            }

        }
		
	}
}
