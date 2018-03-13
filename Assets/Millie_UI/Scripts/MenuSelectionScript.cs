using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuSelectionScript : MonoBehaviour {


    public GameObject correspondingIngredients;
    public Button menuItems;
    public Color selectedItem;
    public Color unselectedItem;
    public Image colour;

    public MenuCounterInventory MC;

    public bool clicked = false;
    public bool buttonsDisabled = false;


    
    // Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (MC.counter >= 2)
        {
            menuItems.GetComponent<Button>().interactable = false;
            //buttonsDisabled = true;
        }

        //reset colours and status when counter is at 0
        if (MC.counter == 0)
        {
            clicked = false;
            colour.GetComponent<Image>().color = unselectedItem;
        }

        else
        {
            menuItems.GetComponent<Button>().interactable = true;
            
        }

        

    }

    //void "MenuItems" Buttons here - make corresponding ingredients visible - save quantity

    public void MenuItemButton()
    {

        if (clicked == false)
        {

            
            correspondingIngredients.SetActive(true);
            colour.GetComponent<Image>().color = selectedItem;
            clicked = true;
            MC.counter = MC.counter + 1;

            
        }

        else
        {
            clicked = false;
            correspondingIngredients.SetActive(false);
            colour.GetComponent<Image>().color = unselectedItem;

            MC.counter = MC.counter - 1;

        }

       


    }

    
}


   






