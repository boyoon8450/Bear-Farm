using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryManager : MonoBehaviour
{
    GameObject background;
    GameObject UPSIDE;
    GameObject DOWNSIDE;
    GameObject Camera;
    GameObject[] upsideBear = new GameObject[5];
    GameObject[] downsideBear = new GameObject[5];
    GameObject[] grayBear = new GameObject[10];
    //  Use this for initialization
    void Start()
    {
        UPSIDE = GameObject.Find("Upside");
        DOWNSIDE = GameObject.Find("Downside");
        background = GameObject.Find("galleryBackground");
        Camera = GameObject.Find("Main Camera");
        for (int i = 0; i < 10; i++)
        {
            string name = "g_Evilbear" + (char)('A' + i);
            if (i != 0)
            {
                string gBearN = "g_Gbear" + (char)('A' + i);
                grayBear[i] = GameObject.Find(gBearN);
                grayBear[i].SetActive(false);
            }
            Debug.Log(name);
            if (i < 5)
            {
                upsideBear[i] = GameObject.Find(name);
                upsideBear[i].SetActive(false);
            }
            else
            {
                downsideBear[i-5] = GameObject.Find(name);
                downsideBear[i - 5].SetActive(false);
            }
        }

        background.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (!background.activeInHierarchy)
            {
                print("hi~!!!!! active");
                showGallery();
            }
            else
            {
                turnOffGallery();
            }
                
        }
    }

    void showGallery()
    {
        gameObject.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z) +  Camera.transform.forward;
        gameObject.transform.rotation = Camera.transform.rotation;

        background.SetActive(true);
        
        int[] temp = DataManager.returnBearInfo();
        for(int i = 0; i < 10; i++)
        {
            print(i);
            if (i < 5)
            {
                if (temp[i] == 1)
                {
                    upsideBear[i].SetActive(true);
                    if(i != 0)
                        grayBear[i].SetActive(false);
                }
                else
                {
                    upsideBear[i].SetActive(false);
                    grayBear[i].SetActive(true);
                }
            }
            else
            {
                if (temp[i] == 1)
                {
                    downsideBear[i-5].SetActive(true);
                    grayBear[i].SetActive(false);

                }
                else
                {
                    downsideBear[i-5].SetActive(false);
                    grayBear[i].SetActive(true);
                }
            }
        }

    }

    void turnOffGallery()
    {
        for (int i = 0; i < 10; i++)
        {
            if(i!=0)
                grayBear[i].SetActive(false);
            if (i < 5)
            {
                upsideBear[i].SetActive(false);
            }
            else
            {
                downsideBear[i-5].SetActive(false);
            }
        }
        background.SetActive(false);
    }
}
