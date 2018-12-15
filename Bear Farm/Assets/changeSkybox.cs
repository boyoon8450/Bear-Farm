using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkybox : MonoBehaviour {

    public Material night;
    public Material day;

	// Use this for initialization
	void Start () {
        day = RenderSettings.skybox;
    }
	
	// Update is called once per frame
	void Update () {
		//if(Input.GetButtonDown("Fire1"))
  //      {
  //RenderSettings.skybox 를 통해 밤과 낮의 skybox를 바꿀 수 있다
  //          RenderSettings.skybox = night;
  //      }
	}
}
