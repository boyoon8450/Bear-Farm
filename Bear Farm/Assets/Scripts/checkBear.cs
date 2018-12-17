using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkBear : MonoBehaviour
{
    GameObject unlockImg;
    GameObject Camera;
    GameObject dManager;

    private void Start()
    {
        Camera = GameObject.Find("Main Camera");
        unlockImg = GameObject.Find("unlockedImg");
        dManager = GameObject.Find("BearManager");
        unlockImg.SetActive(false);
    }

    //낮이면 0, 밤이면 1을 매개변수로 보냄
    //그리고 친밀도/점수를 두번째 매개변수로 전송한다
    public void canGetBear(int day, int num)
    {
        //Debug.Log("cangetbear : num is " + num);
        int temp = returnIndex(day, num);
        //Debug.Log("temp is " + temp);
        if (temp != -100)
        {
            switch (day)
            {
                case 0:
                    if (temp > DataManager.intimacy_BearNum - 1)
                    {
                        //이 경우, 현재 가지고 있는 곰의 개수보다 가질 수 있는 곰의 개수가 많은 것임
                        //따라서 데이터 업데이트
                        DataManager.updateBearInfo(day, temp);
                        unlockImg.SetActive(true);
                        unlockImg.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z) + Camera.transform.forward * 2f;
                        unlockImg.transform.rotation = Camera.transform.rotation;
                        StartCoroutine(waiting());
                        //Debug.Log("intimacy : bear created!!");
                        dManager.GetComponent<createBear>().setBear();

                    }
                    break;
                case 1:
                    if (temp > DataManager.score_BearNum - 1)
                    {
                        //이 경우, 현재 가지고 있는 곰의 개수보다 가질 수 있는 곰의 개수가 많은 것임
                        //따라서 데이터 업데이트
                        DataManager.updateBearInfo(day, temp);
                        unlockImg.SetActive(true);
                        unlockImg.transform.position = new Vector3(Camera.transform.position.x, Camera.transform.position.y, Camera.transform.position.z) + Camera.transform.forward * 2f;
                        unlockImg.transform.rotation = Camera.transform.rotation;
                        StartCoroutine(waiting());
                        //Debug.Log("score : bear created!!");
                    }
                    break;
            }
        }
        


    }

    int returnIndex(int day, int num)
    {
        //Debug.Log("returnIndex : day is " + day + " and num is " + num);
        int index = -100;
        int i = 0;

        switch (day)
        {
            case 0:
                for (i = 1; i < DataManager.STANDARDSIZE; i++)
                {
                    if (num > DataManager.intimacyStandard[0] && num <= DataManager.intimacyStandard[i])
                    {
                        //Debug.Log("return 0 !!!"+num);
                        return i-1; // 해금될 수 있는 index의 최대를 return해줌
                    }
                    if (num >= DataManager.intimacyStandard[4])
                    {
                        return 4;
                    }
                }
                break;
            case 1:
                for (i = 0; i < DataManager.STANDARDSIZE; i++)
                {
                    //Debug.Log("scoreStandard[" + i + "] is " + DataManager.scoreStandard[i]);
                    if (num >= DataManager.scoreStandard[0] && num <= DataManager.scoreStandard[i])
                    {
                        //Debug.Log("return1!!!");
                        return i-1; // 해금될 수 있는 index의 최대를 return해줌
                    }
                    if (num >= DataManager.scoreStandard[4])
                    {
                        return 4;
                    }
                }
                break;
        }

        return index;
    }

    IEnumerator waiting()
    {
        yield return new WaitForSeconds(1f);
        unlockImg.SetActive(false);
    }
}
