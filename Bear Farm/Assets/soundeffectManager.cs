using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundeffectManager : MonoBehaviour {


    AudioSource Player_audio;
    AudioSource Enemy_audio;
    AudioSource Menu_audio;
    AudioSource Managers_audio;
    AudioSource Enemy_audio2;
    Toggle t;


    // Use this for initialization
    void Start () {

        Player_audio = GameObject.Find("Player").GetComponent<AudioSource>();
        Enemy_audio = GameObject.Find("Enemy").GetComponent<AudioSource>();
        Menu_audio = GameObject.Find("MenuController").GetComponent<AudioSource>();
        Managers_audio = GameObject.Find("Managers").GetComponent<AudioSource>();
        Enemy_audio2 = GameObject.Find("EnemyOriginal").GetComponent<AudioSource>();



        t = gameObject.GetComponent<Toggle>();
    }


    public void valueChanged()
    {
        if (t.isOn)
        {
            Player_audio.mute = false;
            Enemy_audio.mute = false;
            Menu_audio.mute = false;
            Managers_audio.mute = false;
            Enemy_audio2.mute = false;
        }
        else
        {
            Player_audio.mute = true;
            Enemy_audio.mute = true;
            Menu_audio.mute = true;
            Managers_audio.mute = true;
            Enemy_audio2.mute = true;
            
        }
    }
}
