using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class MenuCounterInventory : MonoBehaviour {

    public float counter = 0;
    public GameObject Continue;
    public GameObject chooseAgain;

    public Button[] menuButtonsObject;

    public List<Meal> prelimMenu = new List<Meal>();

    public float tempMoney;
    public Text moneyText;


   
    
    

    

    // Use this for initialization
    void Start ()
    {
        moneyText = moneyText.GetComponent<Text>();
        tempMoney = GameManager.instance.playerGold;

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
        moneyText.text = ("Money: " + tempMoney.ToString());

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


    



    public void ChooseAgainButton()
    {

        counter = 0;
        prelimMenu.Clear();
        tempMoney = GameManager.instance.playerGold;


    }

    public void buttonCall(Button buttonPressed)
    {

        if (buttonPressed == menuButtonsObject[0])
        {
            Debug.Log("Burger Button Pressed");
            prelimMenu.Add(menuButtonsObject[0].GetComponent<SelectMeal>().meal);
        }

        if (buttonPressed == menuButtonsObject[1])
        {
            Debug.Log("Hot Dog Button Pressed");
            prelimMenu.Add(menuButtonsObject[1].GetComponent<SelectMeal>().meal);
        }

        if (buttonPressed == menuButtonsObject[2])
        {
            Debug.Log("Fries Button Pressed");
            prelimMenu.Add(menuButtonsObject[2].GetComponent<SelectMeal>().meal);
        }

        if (buttonPressed == menuButtonsObject[3])
        {
            Debug.Log("Sandwich Button Pressed");
            prelimMenu.Add(menuButtonsObject[3].GetComponent<SelectMeal>().meal);
        }

        if (buttonPressed == menuButtonsObject[4])
        {
            Debug.Log("Potato Soup Button Pressed");
            prelimMenu.Add(menuButtonsObject[4].GetComponent<SelectMeal>().meal);
        }

        if (buttonPressed == menuButtonsObject[5])
        {
            Debug.Log("Fruit Salad Button Pressed");
            prelimMenu.Add(menuButtonsObject[5].GetComponent<SelectMeal>().meal);
        }
    }
    
    public void ConfirmMenu()
    {
        GameManager.instance.menu.Clear();

        foreach (Meal meal in prelimMenu)
        {
           GameManager.instance.AddMeal(meal);
        }

        GameManager.instance.playerGold = tempMoney;
        GameManager.instance.LoadScene("Master_Scene");
    }
    

}
