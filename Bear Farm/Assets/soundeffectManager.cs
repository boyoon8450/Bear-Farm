using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundeffectManager : MonoBehaviour {

    GameObject Player;
    GameObject Enemy;
    GameObject Menu;
    GameObject Managers;
    
    AudioSource Player_audio;
    AudioSource Menu_audio;
    AudioSource Managers_audio;
    AudioSource Enemy_audio2;

    Toggle t;


    // Use this for initialization
    void Awake () {

        Player = GameObject.FindGameObjectWithTag("Player");
        Player_audio = Player.GetComponent<AudioSource>();

        Enemy = GameObject.Find("EnemyOriginal");
        Enemy_audio2 = Enemy.GetComponent<AudioSource>();

        Menu = GameObject.Find("MenuController");
        Menu_audio = Menu.GetComponent<AudioSource>();

        Managers = GameObject.Find("Managers");
        Managers_audio = Managers.GetComponent<AudioSource>();




        t = gameObject.GetComponent<Toggle>();
    }


    public void valueChanged()
    {
        if (t.isOn)
        {
            Player_audio.mute = false;
                       Menu_audio.mute = false;
            Managers_audio.mute = false;
            Enemy_audio2.mute = false;
        }
        else
        {
            Player_audio.mute = true;
            Menu_audio.mute = true;
            Managers_audio.mute = true;
            Enemy_audio2.mute = true;
            
        }
    }
}
