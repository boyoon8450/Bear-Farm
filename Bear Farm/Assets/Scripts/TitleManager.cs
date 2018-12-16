using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject creditMenu;
    AudioSource source;

    bool optionOn;
    bool creditOn;
    bool tutorialOn;


    // Use this for initialization
    void Start () {
        source = gameObject.GetComponent<AudioSource>();
        titleMenu.SetActive(true);
        optionMenu.SetActive(false);
        creditMenu.SetActive(false);
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//스페이스를 메뉴상태에서 누르면 한번씩 뒤로 간다
        {
            source.Play();
            creditMenu.SetActive(false);
            optionMenu.SetActive(false);
            titleMenu.SetActive(true);
        }
    }

    public void onStartClick()
    {
        source.Play();
        DataManager.Load();
        SceneManager.LoadScene("TestNight_B_KYJ");
        //DataManager.Load();
    }

    public void onTutorialClick()
    {
        source.Play();
    }


    public void onOptionClick()
    {
        source.Play();
        titleMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void onCreditClick()
    {
        source.Play();
        titleMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void onExitClick()
    {
        source.Play();
        Application.Quit();
    }

}
