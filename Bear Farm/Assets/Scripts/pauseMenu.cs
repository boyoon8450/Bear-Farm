﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenuPanel;
    //public GameObject pauseUI;
    //public GameObject gameOverUI;
    //public GameObject player;
    //public GameObject button;
    //public static bool clicked;

    // Use this for initialization
    void Start()
    {
        //pause = false;
        //pauseUI = GameObject.Find("pauseMenu");
        //gameOverUI = GameObject.Find("gameOverMenu");
        //gameOverUI.SetActive(false);
        //player = GameObject.FindGameObjectWithTag("Player");
        //button = GameObject.Find("pauseButton");
        //pauseUI.SetActive(false);
        //Debug.Log(pause);
        Time.timeScale = 1;//scene 로드될때 사물들이 움직이게 한다
                           //clicked = false;
        pauseMenuPanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))//뒤로를 누르면 정지메뉴 나타난다
        {
            onPause();
        }

    }

    public void onPause() // Gallery, option, exit button이 뜬다
    {
        // clicked = true;
        pause = !pause;
        if (pause)//정지상태라면
        {
            //pauseUI.SetActive(true);//정지 메뉴가 보이게 한다
            //button.SetActive(false);//정지 버튼이 사라지게 한다
            Time.timeScale = 0;
            pauseMenuPanel.SetActive(true);
            //player.GetComponent<Char_control>().enabled = false;//화면 다른곳을 클릭해도 플레이어는 움직이지 않는다
            //clicked = false;
        }
        else if (!pause)//정지상태가 아니라면
        {
            Debug.Log("play");
            //pauseUI.SetActive(false);//정지 메뉴를 안보이게 한다
            //button.SetActive(true);//정지 버튼이 보이게 한다
            pauseMenuPanel.SetActive(false);
            Time.timeScale = 1;
            //player.GetComponent<Char_control>().enabled = true;//플레이어가 다시 움직일 수 있게 한다
            //clicked = false;
        }
    }

    public void Resume()
    {
        //SoundManager.instance.PlaySoundTime("click", 0.5f);
        //GameObject.Find("field").GetComponent<AudioSource>().Play();
        pause = false;
        //pauseUI.SetActive(false);//정지 메뉴를 안보이게 한다
        //button.SetActive(true);//정지 버튼이 다시 보이게 한다
        Time.timeScale = 1;//다시 움직이게 한다
        //player.GetComponent<Char_control>().enabled = true;//플레이어가 다시 움직일 수 있게 한다

    }

    //public void mainMenu()//메인 메뉴로 돌아간다
    //{
    //    SoundManager.instance.PlaySoundTime("click", 0.5f);
    //    SceneManager.LoadScene("Start");
    //}
    //public void Restart()
    //{

    //    SoundManager.instance.PlaySoundTime("click", 0.5f);
    //    int scene = SceneManager.GetActiveScene().buildIndex;
    //    SceneManager.LoadScene(scene, LoadSceneMode.Single);
    //}

    //public void deadMenu()//플레이어가 죽었을때 gameOverMenu가 보이게 한다
    //{
    //    GameObject.Find("field").GetComponent<AudioSource>().Stop();
    //    //Debug.Log("deadmenu");
    //    gameOverUI.SetActive(true);
    //}
}