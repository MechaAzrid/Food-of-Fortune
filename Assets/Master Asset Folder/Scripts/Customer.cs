using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {

    public CustomerStats customer; // customerStats class 
    public bool orderCompleted;
    public bool inLine;
    public bool talking;
    private CustomerManager CM; // links to the customer manager
    private GameManager GM; // links to the customer manager

    public int randomNumber;
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
        // Checking the Global Food Percentage
        float choice1 = 0f;
        float choice2 = 0f;

        // Unhealthy setting of choice;
        if (GM.foodPercentage <= 0)
        {
            choice1 = 30;
            choice2 = 70;
        }

        if (GM.foodPercentage <= -5)
        {
            choice1 = 20;
            choice2 = 80;
        }

        if (GM.foodPercentage <= -10)
        {
            choice1 = 10;
            choice2 = 90;
        }

        // Healthy Setting of choice;
        if (GM.foodPercentage >= 5)
        {
            choice2 = 20;
            choice1 = 80;
        }

        if (GM.foodPercentage >= 10)
        {
            choice2 = 10;
            choice1 = 90;
        }

        // Selecting of Meal

        if (CM.menu[0].healthy == true)
        {
            meal1Chance = choice1;
        }

        else
        {
            meal1Chance = choice2;
        }

        if (CM.menu[1].healthy == true)
        {
            meal2Chance = choice1;
        }

        else
        {
            meal2Chance = choice2;
        }

        // checks to see if they are both unhealthy
        if (meal1Chance == meal2Chance)
        {
            meal1Chance = 50;
            meal2Chance = 50;
        }

        randomNumber = Random.Range(0, 100); // selects a random number to select a meal
        if (GameManager.instance.prototyping == true) print("Random Number is " + randomNumber);

        if (randomNumber <= choice1)
        {
            if (meal1Chance == choice1)
            {
                customer.chosenMeal = CM.menu[0];
            }

            else if (meal2Chance == choice1)
            {
                customer.chosenMeal = CM.menu[1];
            }
        }

        else if (randomNumber > choice1)
        {
            if (meal1Chance == choice2)
            {
                customer.chosenMeal = CM.menu[0];
            }

            else if (meal2Chance == choice2) 
            {
                customer.chosenMeal = CM.menu[1];
            }

            else
            {
                if (randomNumber <= 50)
                {
                    customer.chosenMeal = CM.menu[0];
                }

                else
                {
                    customer.chosenMeal = CM.menu[1];
                }
            }
        }

        CM.CreateOrder(customer.chosenMeal, customer.orderNumber); // send the order to the customer manager to be created

    }

}
