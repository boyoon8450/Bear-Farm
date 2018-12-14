using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="Enemy")
        {
            Destroy(gameObject);
        }
    }
}
