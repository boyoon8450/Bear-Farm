using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forgaze : MonoBehaviour
{
    private GameObject manager;
    interaction forinteraction;
    public bool gazed;


    private void Awake()
    {
        manager = GameObject.Find("Managers");

        forinteraction = manager.GetComponent<interaction>();
        //gazedAt = false;
    }

    public void onPointerEnter()
    {

        forinteraction.gazed_at = true;
        gazed = true;
        forinteraction.obj_name = gameObject.name;
        //parent obejct의 이름을 보냄
        forinteraction.bear_name = this.transform.parent.gameObject.name;
        


    }

    public void onPointerExit()
    {
        forinteraction.gazed_at = false;
        gazed = false;
        //forinteraction.bear_name = this.transform.parent.gameObject.name;


    }
}
