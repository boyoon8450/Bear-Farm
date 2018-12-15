using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowIntimacy : MonoBehaviour {

    public Text intimacyText;

	void Update () {
        intimacyText.text = "Intimacy : " + DataManager.totalIntimacy.ToString();
	}
}
