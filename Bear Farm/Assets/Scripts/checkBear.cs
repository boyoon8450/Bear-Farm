using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkBear : MonoBehaviour {
    
    //낮이면 0, 밤이면 1을 매개변수로 보냄
    //그리고 친밀도/점수를 두번째 매개변수로 전송한다
	public void canGetBear(int day, int num)
    {
        int temp = returnIndex(day, num);
        if(temp!= -1)
        {
            switch (day)
            {
                case 0:
                    if (temp > DataManager.intimacy_BearNum - 1)
                    {
                        //이 경우, 현재 가지고 있는 곰의 개수보다 가질 수 있는 곰의 개수가 많은 것임
                        //따라서 데이터 업데이트
                        DataManager.updateData(day, temp);
                    }
                    break;
                case 1:
                    if (temp > DataManager.score_BearNum - 1)
                    {
                        //이 경우, 현재 가지고 있는 곰의 개수보다 가질 수 있는 곰의 개수가 많은 것임
                        //따라서 데이터 업데이트
                        DataManager.updateData(day, temp);
                    }
                    break;
            }
        }
        
    }

    int returnIndex(int day, int num)
    {
        int index = -1;
        int i = 0;

        switch (day)
        {
            case 0:
                for (i = 0; i < DataManager.STANDARDSIZE; i++)
                {
                    if (num < DataManager.intimacyStandard[i])
                    {
                        return i - 1; // 해금될 수 있는 index의 최대를 return해줌
                    }
                }
                break;
            case 1:
                for (i = 0; i < DataManager.STANDARDSIZE; i++)
                {
                    if (num < DataManager.scoreStandard[i])
                    {
                        return i - 1; // 해금될 수 있는 index의 최대를 return해줌
                    }
                }
                break;
        }

        return index;
    }
}
