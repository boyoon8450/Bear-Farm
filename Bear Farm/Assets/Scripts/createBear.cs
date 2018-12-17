using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Debug.Log("start called");
        setBear();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded: " + scene.name);
        setBear();
    }

    // Update is called once per frame
    public void setBear () {
        Debug.Log("setBear called");
        if(SceneManager.GetActiveScene().name == "TestNight_B")
        {
            for (int i = 0; i < 10; i++)
            {
                //Debug.Log(i+" haveBear : " + DataManager.haveBear[i]);
                if (DataManager.haveBear[i] == 1)
                {
                    //Debug.Log("setbear : " + i + "is true");
                    bears[i].SetActive(true);
                }
                else
                {
                    bears[i].SetActive(false);
                }

            }
        }
       
		
	}
}
