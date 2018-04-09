using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerManager : MonoBehaviour
{
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
    public List<Ingredient> ingredientList = new List<Ingredient>(); // master list of ingredient 
    public List<string> customerNames = new List<string>(); // list of all possible names
    public List<Sprite> customerPotraits = new List<Sprite>(); // list for all possible portraits
    public bool firstCustomerSpawned; // Set to allow randomised spawning when true
    public bool talking = false; 

    [Header("UI Elements")]
    public Image customerPortrait; // where the customer appears in the window
    public Image mealToMake;
    public Image orderIngredient1;
    public Image orderIngredient2;
    

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

    void Awake()
    {
        GameManager.instance.CM = this.GetComponent<CustomerManager>();
    }

    // Use this for initialization
    void Start()
    {
       
        // Game Manager
        
        customerPortrait.sprite = null; // makes sure the customer portrait is empty 
        customerPortrait.enabled = !enabled;
        customerOrdering = null; // ensures no customer is set to order
        currentMeal = null; // ensures the current meal is set to nothing
        currentOrderNumber = 1; // sets the order number to 1

        // testing for auto setting of health
        foreach (Meal meal in mealList)
        {
            if (meal.mealHealth > 0)
            {
                meal.healthy = true;
            }
        }

        GameManager.instance.CM = this.gameObject.GetComponent<CustomerManager>();

        UpdateMenu();
        
    }

    public void UpdateMenu()
    {
        Meal meal0 = GameManager.instance.menu[0];
        Meal meal1 = GameManager.instance.menu[1];

        menu[0] = meal0;
        menu[1] = meal1;
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

                    customerPortrait.enabled = enabled;
                    customerPortrait.sprite = customerOrdering.customer.sprite;
                    customerOrdering.SelectOrder(); // tells the customer to order
                }

                break;

            case CustomerInteraction.PREPARINGORDER:

                break;


            case CustomerInteraction.COMPLETEDORDERCORRECTLY:
                if (ordering == true)
                {
                    //you get monies added to the playerCurrency
                    GameManager.instance.playerGold += currentMeal.mealCost;
                    GameManager.instance.earnedGold += currentMeal.mealCost;
                    if (GameManager.instance.prototyping) print(GameManager.instance.playerGold);

                    interactionManager = CustomerInteraction.RESETORDER;

                    talking = false;
                   
                }
                break;

            case CustomerInteraction.COMPLETEORDERINCORRECTLY:
                {
                    GameManager.instance.playerGold -= currentMeal.mealCost;
                    GameManager.instance.earnedGold -= currentMeal.mealCost;
                    if (GameManager.instance.prototyping) print(GameManager.instance.playerGold);

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
                    customerPortrait.enabled = !enabled;

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
        randomNumber = Random.Range(0, 6);
        stats.customer.sprite = customerPotraits[randomNumber];

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

    }

    public void CompleteOrderCorrectlyButton()
    {
        if (ordering)
        {
            // Sets the Interaction to Completed Order
            interactionManager = CustomerInteraction.COMPLETEDORDERCORRECTLY;
        }
    }

    public void CompleteOrderIncorrectlyButton()
    {
        if (ordering)
        {
            //Sets interaction to incorrect completed order
            interactionManager = CustomerInteraction.COMPLETEORDERINCORRECTLY;
        }
    }
    
}

