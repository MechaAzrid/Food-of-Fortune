using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateMoneyText : MonoBehaviour {

	private Text text;

	private void Awake() {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	private void Update () {
		text.text = "Money: " + GameManager.instance.playerGold;
	}
}
