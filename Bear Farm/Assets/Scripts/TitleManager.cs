using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Sprites;

public class TitleManager : MonoBehaviour {

    public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject creditMenu;
    public GameObject tutorialMenu;
    public Text tutorialText;
    AudioSource source;

    bool optionOn;
    bool creditOn;
    bool tutorialOn;

    Sprite[] tutorialImages;
    public GameObject imagePanel;
    int sceneNum;


    // Use this for initialization
    void Start () {
        source = gameObject.GetComponent<AudioSource>();
        tutorialImages = Resources.LoadAll<Sprite>("Tutorial");
        titleMenu.SetActive(true);
        optionMenu.SetActive(false);
        creditMenu.SetActive(false);
        sceneNum=0;
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//스페이스를 메뉴상태에서 누르면 한번씩 뒤로 간다
        {
            source.Play();
            creditMenu.SetActive(false);
            optionMenu.SetActive(false);
            tutorialMenu.SetActive(false);
            titleMenu.SetActive(true);
        }
        if(tutorialMenu.gameObject.activeSelf)
        {
            imagePanel.GetComponent<Image>().sprite = tutorialImages[0];
            tutorialText.text = "Welcome to the Teddy Bear Farm!";
            //플레이어가 한번씩 x 누를때마다 이미지가 넘어간다
            if(Input.GetButtonDown("Fire1"))
            {
                source.Play();
                sceneNum++;
            }
            if(sceneNum == 1)
            {
                tutorialText.text = "You can interact with Teddy Bears \nby pressing X";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[1];
            }
            else if(sceneNum == 2)
            {
                tutorialText.text = "You need to protect your bears!\nShoot the thief by pressing X";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[4];
            }
            else if (sceneNum == 3)
            {
                tutorialText.text = "If your score and intimacy \nis high enough,\nbears will be unlocked!";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[6];
            }
            else if (sceneNum == 4)
            {
                tutorialText.text = "Check how many bears \nyou collected in the menu\nby pressing Triangle";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[3];
            }
            else if (sceneNum == 5)
            {
                tutorialText.text = "There are 10 bears!\nDo your best to collect them all!";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[2];
            }
            else if (sceneNum == 6)
            {
                tutorialText.text = "You can change sound at option\nin the menu";
                imagePanel.GetComponent<Image>().sprite = tutorialImages[5];
            }
            else if (sceneNum == 7)
            {
                sceneNum = 0;
                //creditMenu.SetActive(false);
                //optionMenu.SetActive(false);
                tutorialMenu.SetActive(false);
                titleMenu.SetActive(true);
            }
        }
    }

    public void onStartClick()
    {
        source.Play();
        DataManager.Load();
        SceneManager.LoadScene("TestNight_B");
        //DataManager.Load();
    }

    public void onTutorialClick()
    {
        source.Play();
        titleMenu.SetActive(false);
        tutorialMenu.SetActive(true);
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
