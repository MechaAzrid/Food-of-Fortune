using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateRemainingTime : MonoBehaviour {
	private Text text;

	private void Awake() {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	private void Update () {
		text.text = string.Format("Time remaining: {0:#.00}", (GameManager.instance.maxShiftTime - GameManager.instance.shiftTime));
           
	}
}
