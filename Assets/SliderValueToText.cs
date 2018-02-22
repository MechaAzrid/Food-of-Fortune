using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SliderValueToText : MonoBehaviour {

    Text textComponent;

    // Use this for initialization
    void Start () {
        textComponent = GetComponent<Text>();
		
	}

    public void SetSliderValue(float sliderValue)
    {
        textComponent.text = Mathf.Round(sliderValue *10).ToString();
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
