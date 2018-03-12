using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool prototyping;

    [Header("World Variables")]
    public static GameManager instance = null; // allows for this object to become static in awake
    public float foodPercentage; // what the average health vs unhealthy food stat is

    public PauseManager PM;

    [Header("Player Variables")]
    public float playerGold; // how much gold the player has

    // PRIVATE VARIABLES
    private CustomerManager CM; // links to customer manager

    void Awake()
    {

        if (instance == null) // Check if instance already exists
        {
            instance = this; // this is instance
        }

        else if (instance != this) //If instance already exists
        {
            Destroy(gameObject); // destroys this 
        }

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        foodPercentage = 0; // resets the percentage
        CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>(); // links the game manager to customer manager
        PM = GetComponent<PauseManager>();
    }

    void Update()
    {
        
    }

    public void UpdateHealthMeter() // Responsible for Updated the Overall Health Meter
    {
        float healthValue = 0; // used to calculate the health value

        if (CM.customersCompleted.Count >= 1)
        {

            foreach (GameObject order in CM.customersCompleted) // for each customer that has been completed it grabs the health value of the meal and adds it
            {
                // Grabbing Customer and Meal
                Customer completedCustomer = order.GetComponent<Customer>(); // link to the customer
                Meal meal = completedCustomer.customer.chosenMeal; // link to the chosen meal

                healthValue += meal.mealHealth; // adds meal health value 
            }

            foodPercentage = healthValue / CM.customersCompleted.Count; // divides the health value by the number of completed customers to calculate the average

            // if (CM.customersCompleted.Count >= 1)
            foreach (GameObject gameObject in CM.customersCompleted)
            {
                DestroyObject(gameObject);
            }

            CM.customersCompleted.Clear(); 
        }

    }

    public void SaveGame()
    {
        print("Calling Save Game");
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("playerGold", playerGold);
        PlayerPrefs.Save();
        print("Saved!");
    }

    public void LoadGame()
    {
        print("Loading Game");
        PlayerPrefs.GetFloat("playerGold", playerGold);
        print("Loaded!");
    }

} 