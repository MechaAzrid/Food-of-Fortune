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
        float healthyChoice = 0f;
        float unhealthyChoice = 0f;

        // Unhealthy setting of choice;
        if (GM.foodPercentage <= 0)
        {
            healthyChoice = 30;
            unhealthyChoice = 70;
        }

        if (GM.foodPercentage <= -5)
        {
            healthyChoice = 20;
            unhealthyChoice = 80;
        }

        if (GM.foodPercentage <= -10)
        {
            healthyChoice = 10;
            unhealthyChoice = 90;
        }

        // Healthy Setting of choice;
        if (GM.foodPercentage >= 5)
        {
            unhealthyChoice = 20;
            healthyChoice = 80;
        }

        if (GM.foodPercentage >= 10)
        {
            unhealthyChoice = 10;
            healthyChoice = 90;
        }

        // Selecting of Meal

        if (CM.menu[0].healthy == true)
        {
            meal1Chance = healthyChoice + CM.menu[0].mealHealth; 
        }

        else
        {
            meal1Chance = unhealthyChoice - CM.menu[0].mealHealth;
        }

        if (CM.menu[1].healthy == true)
        {
            meal2Chance = healthyChoice + CM.menu[1].mealHealth;
        }

        else
        {
            meal2Chance = unhealthyChoice - CM.menu[1].mealHealth;
        }

        if (CM.menu[0].healthy == true && CM.menu[1].healthy == true)
        {
            
            meal1Chance = 50 + CM.menu[0].mealHealth;
            meal2Chance = 50 + CM.menu[1].mealHealth;
        }

        // Runs the Calculation
        RerollOrder();

        print(customer.thename + " has chosen " + customer.chosenMeal);

        CM.CreateOrder(customer.chosenMeal, customer.orderNumber); // send the order to the customer manager to be created
    }

    public void RerollOrder()
    {
        // RUns the Calculation to determine what meal is chosen
        randomNumber = Random.Range(0, 100); // selects a random number to select a meal
        if (GameManager.instance.prototyping == true) print("Random Number is " + randomNumber);

        if (meal1Chance >= meal2Chance) // if meal 1 chance is higher than meal 2
        {
            Debug.LogWarning("Meal 1 Chance is higher than meal 2");
            if (randomNumber <= meal2Chance)
            {
                customer.chosenMeal = CM.menu[1];
            }

            else //if (randomNumber <= meal1Chance)
            {
                customer.chosenMeal = CM.menu[0];
            }

            /*
            else
            {
                Debug.LogWarning("Customer hasnt chosen a meal and is re-rolling");
                RerollOrder();
            }
            */
        }

        else
        {
            if (randomNumber <= meal2Chance)
            {
                Debug.LogWarning("Meal 2 Chance is higher than meal 1");
                if (randomNumber <= meal1Chance)
                {
                    customer.chosenMeal = CM.menu[0];
                }

                else //if (randomNumber <= meal2Chance)
                {
                    customer.chosenMeal = CM.menu[1];
                }

                /*
                else
                {
                    Debug.LogWarning("Customer hasnt chosen a meal and is re-rolling");
                    RerollOrder();
                }
                */
            }
        }
    }

}
