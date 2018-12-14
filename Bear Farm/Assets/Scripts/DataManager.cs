using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    //관리할 데이터 : 갤러리 > 곰의 수집 여부, 곰마다의 친밀도 수치(int[]), 총 친밀도 수치(int), 하이스코어(int)
    //0~4 / 5~9 : 각각 낮과 밤. 

    public static int BEARSIZE = 10; //그때 열마리?라고 한거같은데 갤러리 캡처는 12마리고 그래서 일단 10마리...
    public  static int STANDARDSIZE = BEARSIZE / 2;

    public static int[] haveBear = new int[BEARSIZE];
    public static int[] bearIntimacy = new int[BEARSIZE];
    public static int totalIntimacy;
    public static int highScore;

    public static int[] intimacyStandard = new int[STANDARDSIZE];
    public static int[] scoreStandard = new int[STANDARDSIZE];

    public static int intimacy_BearNum;
    public static int score_BearNum;

    //Scene 이동 시에도 계속 이동할 수 있게~~
    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        int i = 0;
        for (i = 0; i < STANDARDSIZE; i++)
        {
            //일단 둘 다 50부터 250까지로 설정해 둠 ㅇ0ㅇ)
            intimacyStandard[i] = 50 * (i + 1);
            scoreStandard[i] = 50 * (i + 1);
        }
        intimacy_BearNum = 0;
        score_BearNum = 0;
        Load();
    }

    //데이터 로드
    public void Load()
    {
        string[] t_haveBear = PlayerPrefs.GetString("BearInfo", "1/0/0/0/0/0/0/0/0/0").Split('/');
        //string[] t_haveBear = PlayerPrefs.GetString("BearInfo", "1/1/1/1/1/1/1/1/1/1").Split('/');
        string[] t_bearIntimacy = PlayerPrefs.GetString("BearIntimacy", "0/0/0/0/0/0/0/0/0/0").Split('/');
        totalIntimacy = PlayerPrefs.GetInt("Intimacy", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        int i;

        for (i = 0; i < BEARSIZE; i++)
        {
            haveBear[i] = int.Parse(t_haveBear[i]);
            if(haveBear[i] == 1)
            {
                if (i < 5)
                    intimacy_BearNum++;
                else
                    score_BearNum++;
            }
            bearIntimacy[i] = int.Parse(t_bearIntimacy[i]);
        }
    }

    public void Save()
    {
        PlayerPrefs.SetString("BearInfo", makeString(haveBear));
        PlayerPrefs.SetString("BearIntimacy", makeString(bearIntimacy));
        PlayerPrefs.SetInt("Intimacy", totalIntimacy);
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public static int[] returnBearInfo()
    {
        return haveBear;
    }

    public int returnTotalintimacy()
    {
        return totalIntimacy;
    }

    public int returnHighscore()
    {
        return highScore;
    }
    
    public static void updateScoreInfo(int score)
    {

    }

    public static void updateIntimacyInfo(int intimacy)
    {

    }

    public static void updateBearInfo(int day,int index)
    {
        int i = 0;
        for (i = 0; i <= index; i++)
        {
            if(haveBear[5 * day + i] == 0)
            {
                if(day == 0)
                {
                    intimacy_BearNum++;
                }
                else
                {
                    score_BearNum++;
                }
            }
            haveBear[5 * day + i] = 1;
           
        }
    }

    string makeString(int[] arr)
    {
        string str = "";
        int i;

        for (i = 0; i < arr.Length - 1; i++)
        {
            str += arr[i].ToString();
            str += "/";
        }

        str = str + arr[i];

        return str;
    }
}