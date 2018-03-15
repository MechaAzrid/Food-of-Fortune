using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerManager : MonoBehaviour
{
    private GameManager GM;

    [Header("Customer Variables")]
    public GameObject baseCustomer; // Default customer to spawn
    public GameObject completedCustomerLineParent; // parent object for customers that have recieved orders
    public GameObject customerLineParent; // parent object for the customer line
    public int firstSpawnTime; // The First Customer spawns at this time
    public int minSpawnTime; // min amount of time that can be past before a customer spawns
    public int maxSpawnTime; // max amount of time that can be past before a customer spawns
    public float countdownTillSpawn; // counts down till spawn time
    public int maxCustomers; // Max amount of customers that can exist at 1 time
    public int spawnedCustomers; // amount of customers that have been spawned
    public List<Meal> menu = new List<Meal>(); // Items on the Menu that the player has selected
    public List<Meal> mealList = new List<Meal>(); // List for what meals are available
    public List<string> customerNames = new List<string>(); // list of all possible names
    public bool firstCustomerSpawned; // Set to allow randomised spawning when true
    public bool talking = false; 

    [Header("UI Elements")]
    public Image customerPortrait; // where the customer appears in the window
    public Sprite customerSprite; // what the customer looks like

    public enum CustomerInteraction
    {
        WAITING, // Standby Mode
        TAKINGORDER, //Taking an Order from a Customer
        PREPARINGORDER, // Making the Customers Order
        COMPLETEDORDERCORRECTLY, // Customer receives the order and pays for it
        COMPLETEORDERINCORRECTLY, //Customer receives wrong order
        RESETORDER, //reset customer order/
    }

    public CustomerInteraction interactionManager;

    [Header("Order Status")]
    public int currentOrderNumber; // What is the current order number
    public Customer customerOrdering; // used to specify the customer that is currently ordering from player
    public List<GameObject> customersInLine = new List<GameObject>(); // List for Customers in Line
    public List<GameObject> customersCompleted = new List<GameObject>(); // list for completed customers
    public Meal currentMeal; // What meal is being prepared
    public bool ordering; // wether someone is currently ordering from player
    public bool spawningCustomer; // whether a customer is being spawned

    [Header("Debug/Prototyping Options")] 
    public bool prototypingEnabled; // click to enable prototyping buttons
    public Text textOrderNumber; // for the UI
    public Text textOrderedMeal; // for the UI

    // Use this for initialization
    void Start()
    {
        // Game Manager
        GM = GameObject.Find("_GameManager").GetComponent<GameManager>(); // grabs the Game Manager for use

        customerPortrait.sprite = null; // makes sure the customer portrait is empty 
        customerOrdering = null; // ensures no customer is set to order
        currentMeal = null; // ensures the current meal is set to nothing
        currentOrderNumber = 1; // sets the order number to 1

        // UI Order Element Start Up
        textOrderedMeal.GetComponent<Text>();
        textOrderedMeal.text = ("");
        textOrderNumber.GetComponent<Text>();
        textOrderNumber.text = ("");


        // Prototyping Buttons
        if (prototypingEnabled == false) // if set to false, will deactivate any buttons
        {
            
        }
        else // will enable all buttons
        {
            
        }

        // testing for auto setting of health
        foreach (Meal meal in mealList)
        {
            if (meal.mealHealth > 0)
            {
                meal.healthy = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (GameManager.instance.prototyping == true)
            print("Interaction Manager is in " + interactionManager);
         
        // Spawning Customer
        if (spawningCustomer == false)
        {
            StartCoroutine(SpawningCustomer());
        }

        countdownTillSpawn -= Time.deltaTime;

        switch (interactionManager)
        {
            case CustomerInteraction.WAITING: // Standby Phase

                if (customersInLine.Count >= 1) // checks to see if there are any customers in line
                {
                    if (GameManager.instance.prototyping) print("There is a customer in line");
                    if (ordering == false) // checks to see if anyone is currently ordering
                    {
                        customerOrdering = customersInLine[0].GetComponent<Customer>(); // sets the customer that is ordering to the first in line
                        interactionManager = CustomerInteraction.TAKINGORDER; // sets the interaction manager to taking an order
                    }

                }
                break;

            case CustomerInteraction.TAKINGORDER:

                if (ordering == false)
                {
                    ordering = true; // customer is now ordering
                    customerOrdering.serviceState = Customer.CustomerState.ORDERING; // sets the customer to ordering
                    customerOrdering.customer.orderNumber = currentOrderNumber; // sets the order number of customer
                    if (GameManager.instance.prototyping)
                    {
                        print(customerOrdering.customer.thename + " is now ordering (" + customerOrdering.customer.orderNumber + ")");
                    }

                    if (talking == false)
                    {
                        print("CHANGING TEXT");
                        talking = true;
                        GetComponent<CustomerDialogue>().UpdateText();
                    }

                    customerOrdering.SelectOrder(); // tells the customer to order
                }

                break;

            case CustomerInteraction.PREPARINGORDER:

                break;


            case CustomerInteraction.COMPLETEDORDERCORRECTLY:
                if (ordering == true)
                {
                    //you get monies added to the playerCurrency
                    GM.playerGold += currentMeal.mealCost;
                    GM.earnedGold += currentMeal.mealCost;
                    if (GameManager.instance.prototyping) print(GM.playerGold);

                    interactionManager = CustomerInteraction.RESETORDER;

                    talking = false;
                   
                }
                break;

            case CustomerInteraction.COMPLETEORDERINCORRECTLY:
                {
                    GM.playerGold -= currentMeal.mealCost;
                    GM.earnedGold -= currentMeal.mealCost;
                    if (GameManager.instance.prototyping) print(GM.playerGold);

                    interactionManager = CustomerInteraction.RESETORDER;

                    talking = false;
                }

                break;

            case CustomerInteraction.RESETORDER:
                if (ordering == true)
                {
                    ordering = false; // starts to reset cycle

                    currentMeal = null; // resets the meal

                    // Resets the Customer
                    customerOrdering.orderCompleted = true; // sets the order to completed
                    customerOrdering.serviceState = Customer.CustomerState.ORDERCOMPLETE; // sets the customer order state to completed
                    customerOrdering = null; // resets whos ordering
                    currentMeal = null; // resets the current meal

                    // Resets the Order Panel
                    textOrderedMeal.GetComponent<Text>();
                    textOrderedMeal.text = ("");
                    textOrderNumber.GetComponent<Text>();
                    textOrderNumber.text = ("");

                    // Increases Order number for next order and Resets the interaction
                    currentOrderNumber++; // increases the order number once an order has been finished
                    GameManager.instance.customersServed++;
                    customersInLine.RemoveAt(0); // removes the customer at front of the line
                    interactionManager = CustomerInteraction.WAITING; // changes interaction to waiting
                }

                break;
        }
    }

    public IEnumerator SpawningCustomer()
    {
        if (spawningCustomer)
        {
            yield break;
        }

        spawningCustomer = true;

        int randomNumber = Random.Range(minSpawnTime, maxSpawnTime); // generates a random number between the minimum spawn time and the max spawn time
        if (firstCustomerSpawned == false)
        {
            randomNumber = firstSpawnTime;
            firstCustomerSpawned = true;
        }

        if (GameManager.instance.prototyping) print(randomNumber.ToString() + " is the random spawn number");
        countdownTillSpawn = randomNumber;

        yield return new WaitForSeconds(randomNumber);

        if (customersInLine.Count >= maxCustomers) // checks to see if max customers in line has been exceeded
        {
            spawningCustomer = false;
            yield break; // restarts the sequence
        }

        SpawnCustomer(); // spawns customer
    }

    public void SpawnCustomer() // Spawns in a Customer into the Line
    {
        GameObject newCustomer; // spawns in the prefab for a customer
        newCustomer = Instantiate(baseCustomer, new Vector3(0, 0, 0), Quaternion.identity) as GameObject; // spawns in the customer 
        newCustomer.transform.parent = customerLineParent.transform; // sets the parent to the line object
        Customer stats = newCustomer.GetComponent<Customer>(); // link to the customer stats

        // Randomises Stats
        int randomNumber = Random.Range(0, 10); // Spawns a random number to determine the name of the guest
        stats.customer.thename = customerNames[randomNumber]; // selects a random name amoungs the list

        customersInLine.Add(newCustomer); // adds the customer to the line (customerInLine List)
        stats.inLine = true;

        spawnedCustomers++; // adds one to the number of spawned customers
        spawningCustomer = false; // allows the reseting of spawning
       
    }

    public void SpawnCustomerButton ()
    {
        GameObject newCustomer; // spawns in the prefab for a customer
        newCustomer = Instantiate(baseCustomer, new Vector3(0, 0, 0), Quaternion.identity) as GameObject; // spawns in the customer 
        newCustomer.transform.parent = customerLineParent.transform; // sets the parent to the line object
        Customer stats = newCustomer.GetComponent<Customer>(); // link to the customer stats

        // Randomises Stats
        int randomNumber = Random.Range(0, 10); // Spawns a random number to determine the name of the guest
        stats.customer.thename = customerNames[randomNumber]; // selects a random name amoungs the list

        customersInLine.Add(newCustomer); // adds the customer to the line (customerInLine List)
        stats.inLine = true;

        spawnedCustomers++; // adds one to the number of spawned customers
    }

    public void CreateOrder(Meal orderedMeal, int orderNumber)
    {
        interactionManager = CustomerInteraction.PREPARINGORDER; // starts to prepare order
        customerOrdering.serviceState = Customer.CustomerState.WAITINGFORORDER; // sets the customer state to waiting for order

        currentMeal = orderedMeal; // sets the ordered meal to the order

        textOrderNumber.text = ("Order Number :" + orderNumber.ToString()); // sets the UI number (Prototyping Only)
        textOrderedMeal.text = ("Meal: " + orderedMeal.mealName); // sets the UI meal (Prototyping Only)

    }

    public void CompleteOrderCorrectlyButton()
    {
        // Sets the Interaction to Completed Order
        interactionManager = CustomerInteraction.COMPLETEDORDERCORRECTLY;
    }

    public void CompleteOrderIncorrectlyButton()
    {
        //Sets interaction to incorrect completed order

        interactionManager = CustomerInteraction.COMPLETEORDERINCORRECTLY;
    }
    
}

