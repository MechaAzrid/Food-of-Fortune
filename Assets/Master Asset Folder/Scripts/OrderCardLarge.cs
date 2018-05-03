using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderCardLarge : MonoBehaviour {

    public Image largeOrderImage;
    public GameObject largeOrder;
    public CustomerManager CM;

    //public Meal meal;


	// Use this for initialization
	void Start ()
    {
        largeOrder.SetActive(false);
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OrderClicked()
    {
        largeOrder.SetActive(true);

        largeOrderImage.sprite = CM.mealToMake.sprite;

    }

    public void OrderExit()
    {
        largeOrder.SetActive(false);
        
    }
}
