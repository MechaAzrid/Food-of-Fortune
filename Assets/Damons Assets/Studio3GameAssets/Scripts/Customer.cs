using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {

    public CustomerStats customer; // customerStats class 
    public bool orderCompleted;
    public bool inLine;
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

        if (CM.menu[0].healthy == true)
        {
            meal1Chance = 30;
        }

        else
        {
            meal1Chance = 70;
        }

        if (CM.menu[1].healthy == true)
        {
            meal2Chance = 30;
        }

        else
        {
            meal2Chance = 70;
        }

        // checks to see if they are both unhealthy
        if (meal1Chance == meal2Chance)
        {
            meal1Chance = 50;
            meal2Chance = 50;
        }

        randomNumber = Random.Range(0, 100); // selects a random number to select a meal
        if (CM.debugLines) print("Random Number is " + randomNumber);

        if (randomNumber <= 30)
        {
            if (meal1Chance == 30)
            {
                customer.chosenMeal = CM.menu[0];
            }

            else if (meal2Chance == 30)
            {
                customer.chosenMeal = CM.menu[1];
            }
        }

        else if (randomNumber > 30)
        {
            if (meal1Chance == 70)
            {
                customer.chosenMeal = CM.menu[0];
            }

            else if (meal2Chance == 70)
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
