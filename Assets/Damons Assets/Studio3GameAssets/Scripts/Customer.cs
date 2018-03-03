using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {

    public CustomerStats customer; // customerStats class 
    public bool orderCompleted;
    public bool inLine;
    private CustomerManager CM; // links to the customer manager
    private GameManager GM; // links to the customer manager

    public float mealChance;
    public float meal1Chance;
    public float meal2Chance;

    public enum CustomerState // State Machine for Customer
    {
        WAITING, // Doing nothing, waiting for input/to do anything
        INLINE, // used when customer is waiting in line to order
		ORDERING, // allows the customer to order
        WAITINGFORORDER, // customer is now waiting for their food to be made
        ORDERCOMPLETE, // once the customer has ordered, they wait to receive their food
    }

    public CustomerState serviceState;

    void Start()
    {
        serviceState = CustomerState.WAITING; // makes sure their service state is set to waiting
        CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>();
        GM = GameObject.Find("_GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        switch (serviceState)
        {
            case (CustomerState.WAITING):
                if (inLine) // if in the line, it sets the state to in line
                {
                    serviceState = CustomerState.INLINE;
                }

            break;

            case (CustomerState.INLINE):

                break;

            case (CustomerState.ORDERING):

                break;

            case (CustomerState.WAITINGFORORDER):

                break;


            case (CustomerState.ORDERCOMPLETE):
                this.gameObject.transform.parent = CM.completedCustomerLineParent.transform; // moves this object to the completed parent
                CM.customersCompleted.Add(this.gameObject);
                inLine = false;
                serviceState = CustomerState.WAITING;
				break;
        }
       
    }

	public void SelectOrder() // Used to Create customer Order
	{
        if (CM.menu[0].mealHealth < 0)
        {
            meal1Chance = 70;
        }

        else if (CM.menu[0].mealHealth > 0)
        {
            meal1Chance = 30;
        }

        if (CM.menu[1].mealHealth < 0)
        {
            meal2Chance = 70;
        }

        else if (CM.menu[1].mealHealth > 0)
        {
            meal2Chance = 30;
        }

        // Selecting a Meal
        int randomNumber = Random.Range(0, 100); // selects a random number to select a meal (will be swapped out at a later date for unhealthy/healthy formula)

        if (CM.debugLines) print("Random Number is "+ randomNumber);
        if (CM.debugLines) print(customer.thename + " is picking a meal");

        if (meal1Chance > meal2Chance)
        {
            meal1Chance = 70;
            meal2Chance = 30;
        }

        else if (meal2Chance > meal1Chance)
        {
            meal2Chance = 70;
            meal1Chance = 30;
        }

        else if (meal1Chance == meal2Chance)
        {

        }

        customer.chosenMeal = CM.mealList[randomNumber]; // picks a meal based of the number

        if (CM.debugLines) print(customer.thename + " chosen meal is " + customer.chosenMeal);

        CM.CreateOrder(customer.chosenMeal, customer.orderNumber); // send the order to the customer manager to be created

    }

}
