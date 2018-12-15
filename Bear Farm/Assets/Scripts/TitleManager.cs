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

    // Use this for initialization
    void Start () {
        source = gameObject.GetComponent<AudioSource>();
        titleMenu.SetActive(true);
        optionMenu.SetActive(false);
        creditMenu.SetActive(false);
	}
	
    public void onStartClick()
    {
        source.Play();
        SceneManager.LoadScene("TestNight");
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

    public void onBackClick()
    {
        source.Play();
        creditMenu.SetActive(false);
        optionMenu.SetActive(false);
        titleMenu.SetActive(true);
    }

    public void onExitClick()
    {
        source.Play();
        Application.Quit();
    }

}
