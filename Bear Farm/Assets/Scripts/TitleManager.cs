using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour {

    public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject creditMenu;

	// Use this for initialization
	void Start () {
        titleMenu.SetActive(true);
        optionMenu.SetActive(false);
        creditMenu.SetActive(false);
	}
	
    public void onStartClick()
    {
        SceneManager.LoadScene("TestNight");
    }

    public void onOptionClick()
    {
        titleMenu.SetActive(false);
        optionMenu.SetActive(true);
    }

    public void onCreditClick()
    {
        titleMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void onBackClick()
    {
        creditMenu.SetActive(false);
        optionMenu.SetActive(false);
        titleMenu.SetActive(true);
    }

    public void onExitClick()
    {
        Application.Quit();
    }

}
