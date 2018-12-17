﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    static public bool pause;
    static public bool galleryOn;
    public bool optionOn;
    bool GalleryOn;
    public GameObject pauseMenuPanel;
    //public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject camera;

    public GameObject galleryM;
    AudioSource source;
    AudioSource enemySound;
    GameObject enemy;
    public GameObject daynight;
    daynightchange daynightchange;
    
    void Start()
    {
        optionOn = false;
        GalleryOn = false;
        Time.timeScale = 1;//scene 로드될때 사물들이 움직이게 한다
        optionMenu.SetActive(false);
        pauseMenuPanel.SetActive(false);
        galleryM = GameObject.Find("GalleryManager");
        source = gameObject.GetComponent<AudioSource>();
        enemySound = GameObject.Find("EnemyOriginal").GetComponent<AudioSource>();
        daynightchange = daynight.GetComponent<daynightchange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Jump") && !optionOn && !galleryOn)//세모 혹은 스페이스를 누르면 정지메뉴 나타난다 이때 option 창도 커져있으면 안된다
        {
            onPause();
        }
        else if(Input.GetButtonUp("Jump") && optionOn)//스페이스를 메뉴상태에서 누르면 한번씩 뒤로 간다
        {
            source.Play();
            optionMenu.SetActive(false);
            pauseMenuPanel.SetActive(true);
            optionOn = false;
        }
        else if(Input.GetButtonUp("Jump") && galleryOn)
        {
            source.Play();
            galleryM.GetComponent<GalleryManager>().turnOffGallery();
            pauseMenuPanel.SetActive(true);
            galleryOn = false;

        }

    }

    public void onPause() // Gallery, option, exit button이 뜬다
    {
        // clicked = true;
        pause = !pause;
        if (pause)//정지메뉴가 나타난다 
        {
            Time.timeScale = 0;         
            pauseMenuPanel.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y+1f, camera.transform.position.z)+ camera.transform.forward * 3f;
            pauseMenuPanel.transform.rotation = camera.transform.rotation;
            pauseMenuPanel.SetActive(true);

            if (!daynightchange.check_day)
            {
                enemy = GameObject.FindGameObjectWithTag("Enemy");
                enemySound = enemy.GetComponent<AudioSource>();
                enemySound.Stop();
            }
        }
        else if (!pause)//정지상태가 아니라면 다시 원래대로 돌아간다
        {
            pauseMenuPanel.SetActive(false);
            Time.timeScale = 1;
            if (!daynightchange.check_day)
                enemySound.Play();
        }
    }

    public void onExitClick()
    {
        source.Play();
        DataManager.Save();
        //Application.Quit();
        SceneManager.LoadScene("Title");
    }

    public void onOptionClick()
    {
        source.Play();
        optionMenu.transform.position = pauseMenuPanel.transform.position;
        optionMenu.transform.rotation = pauseMenuPanel.transform.rotation;
        pauseMenuPanel.SetActive(false);
        optionMenu.SetActive(true);
        optionOn = true;
    }

    public void onGalleryClick()
    {
        source.Play();
        galleryOn = true;
        galleryM.GetComponent<GalleryManager>().showGallery();
        pauseMenuPanel.SetActive(false);
        //optionMenu.SetActive(false);
    }

}