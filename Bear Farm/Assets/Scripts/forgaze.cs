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
        //forinteraction.item_name = gameObject.name;


    }

    public void onPointerExit()
    {
        forinteraction.gazed_at = false;
        gazed = false;
        //forPickup.item_name = null;

    }
}
