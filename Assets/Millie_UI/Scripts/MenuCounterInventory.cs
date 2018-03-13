using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MenuCounterInventory : MonoBehaviour {

    public float counter = 0;
    public GameObject Continue;
    public GameObject chooseAgain;

    public Button[] menuButtonsObject;

    
    

    

    // Use this for initialization
    void Start ()
    {
        
        foreach (Button menuItem in menuButtonsObject)
        {
            menuItem.onClick.AddListener(() => buttonCall(menuItem));
        }

        
        //menuButtonsObject[0].onClick.AddListener(() => buttonCall(menuButtonsObject[0]));
        //menuButtonsObject[1].onClick.AddListener(() => buttonCall(menuButtonsObject[1]));
        

    }

    // Update is called once per frame
    void Update()
    {

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

    
        
        //if two menu buttons are selected then show continue button and disable others


    //public void ContinueButton()
    //{
    //save menu choices and load new scene
    //}



    public void ChooseAgainButton()
    {

        counter = 0;

    }

    public void buttonCall(Button buttonPressed)
    {

        if (buttonPressed == menuButtonsObject[0])
        {
            Debug.Log("Burger Button Pressed");
        }

        if (buttonPressed == menuButtonsObject[1])
        {
            Debug.Log("Hot Dog Button Pressed");
        }

        if (buttonPressed == menuButtonsObject[2])
        {
            Debug.Log("Fries Button Pressed");
        }

        if (buttonPressed == menuButtonsObject[3])
        {
            Debug.Log("Sandwich Button Pressed");
        }

        if (buttonPressed == menuButtonsObject[4])
        {
            Debug.Log("Potato Soup Button Pressed");
        }

        if (buttonPressed == menuButtonsObject[5])
        {
            Debug.Log("Fruit Salad Button Pressed");
        }
    }
    


}
