using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuCounterInventory : MonoBehaviour {

    public float counter = 0;
    public GameObject Continue;
    public GameObject chooseAgain;

    //public GameObject UIButtons;

    //public MenuSelectionScript MS;

     

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if two menu buttons are selected then show continue button and disable others

        if (counter >= 2)
        {

            
            Continue.SetActive(true);
            chooseAgain.SetActive(true);

            
            //show button and disable other buttons
        }

        else
        {
            
            Continue.SetActive(false);
            chooseAgain.SetActive(false);
        }
    }



    //public void ContinueButton()
    //{
    //save menu choices and load new scene
    //}


    //public void ChooseAgainButton()
    //{

    //    UIButtons.GetComponent<Button>().interactable = true;

    //}




}
