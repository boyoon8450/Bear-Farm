using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public bool pause;
    public GameObject pauseMenuPanel;
    //public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject camera;

    // Use this for initialization
    void Start()
    {

        Time.timeScale = 1;//scene 로드될때 사물들이 움직이게 한다
        optionMenu.SetActive(false);
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
            Time.timeScale = 0;         
            pauseMenuPanel.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y+1f, camera.transform.position.z)+ camera.transform.forward * 3f;
            pauseMenuPanel.transform.rotation = camera.transform.rotation;
            pauseMenuPanel.SetActive(true);

        }
        else if (!pause)//정지상태가 아니라면
        {
            pauseMenuPanel.SetActive(false);
            Time.timeScale = 1;

        }
    }

    public void Resume()
    {

        pause = false;
        Time.timeScale = 1;//다시 움직이게 한다


    }

    public void onExitClick()
    {
        Application.Quit();
    }

    public void onBackClick()
    {
        optionMenu.SetActive(false);
        pauseMenuPanel.SetActive(true);
    }

    public void onOptionClick()
    {
        optionMenu.transform.position = pauseMenuPanel.transform.position;
        optionMenu.transform.rotation = pauseMenuPanel.transform.rotation;
        pauseMenuPanel.SetActive(false);
        optionMenu.SetActive(true);
    }

}