﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Added for Saving
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour
{
    [Header("Game Variables")]
    public static GameManager instance = null; // allows for this object to become static in awake
    public PauseManager PM;
    public float foodPercentage; // what the average health vs unhealthy food stat is
    public string savedScene;

    public string master = "Master_Scene"; 

    [Header("Player Variables")]
    public float playerGold; // how much gold the player has

    public float rent;
    public float petrol;

    [Header("Shift Variables")]
    public float shiftTime;
    public float maxShiftTime;
    public bool shiftStarted;
    public bool shiftFinished;
    public List<Meal> menu = new List<Meal>();
    public int customersServed;
    public float earnedGold;

    [Header("Prototyping")]
    public bool prototyping;

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

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == master)
        {
            CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>(); // links the game manager to customer manager
            PM = GetComponent<PauseManager>();
        }

        else
        {
            CM = null;
            PM = null;
            DebugMenu DB = GetComponent<DebugMenu>();
            DB.enabled = !DB.enabled;
        }


    }

    void Start()
    {
        foodPercentage = 0; // resets the percentage

    }

    void Update()
    {
        if (shiftStarted) // checks to see if the shift has started.
        {
            shiftTime += Time.deltaTime; // increases time every second 

            if (shiftTime >= maxShiftTime) // checks to see if the shift time is equal or greater than the max amount of time per shift
            {
                EndShift(); // runs end of shift
            }
        }


    }

    public void AddMeal(Meal meal)
    {
        menu.Add(meal);
        meal.ingredient1.ingredientCost -= playerGold;
        meal.ingredient2.ingredientCost -= playerGold;
    }

    public void UpdateHealthMeter() // Responsible for Updated the Overall Health Meter
    {
        float healthValue = 0; // used to calculate the health value

        if (CM.customersCompleted.Count >= 2)
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

    // Saving Variables
    public void SaveGame()
    {
        // savedScene = SceneManager.GetActiveScene().name;
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save.geoffsbeard");

        print("Creating Save");

        PlayerData data = new PlayerData();

        // Create a new variable for each thing that needs to be saved!
        data.playerGold = playerGold;
        data.foodPercentage = foodPercentage;

        
        // data.savedScene = savedScene;

        bf.Serialize(file, data);
        file.Close();

        print("Saved!");
    }

    /*
    public void AutoSave()
    {
        if (File.Exists(Application.persistentDataPath + "/save.autosave"))
        {
            print("AutoSave Exists!");
            File.Delete(Application.persistentDataPath + "/save.autosave");
            print("but not anymore.....");
        }

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save.autosave");

        print("Autosaving"); 

        PlayerData data = new PlayerData();

        // Create a new variable for each thing that needs to be saved!
        data.playerGold = playerGold;
        data.foodPercentage = foodPercentage;

        bf.Serialize(file, data);
        file.Close();

        print("Saved!");
    }
    */

    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/save.geoffsbeard"))
        {
            print("Save Game Exists!"); 

            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.geoffsbeard", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);

            print("Opening Save");

            playerGold = data.playerGold; 
            foodPercentage = data.foodPercentage;
            // savedScene = data.savedScene;

            print("Save Loaded!");

            LoadScene("Loading Scene");
        }

        /* AUTOSAVE LOAD
        else if (File.Exists(Application.persistentDataPath + "/save.autosave"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.autosave", FileMode.Open);

            PlayerData data = (PlayerData)bf.Deserialize(file);

            playerGold = data.playerGold;
            foodPercentage = data.foodPercentage;
            savedScene = data.savedScene;

            if (savedScene == master)
            {
                LoadScene(master);
                savedScene = null; 
            }
        }
        */
    }

    public void ClearSave()
    {
        if (File.Exists(Application.persistentDataPath + "/save.geoffsbeard"))
        {
            print("Save File Located!");
            File.Delete(Application.persistentDataPath + "/save.geoffsbeard");
            print("Save File Deleted :(");
        }
    }

    public void LoadScene(string scene) // Used to Load Scenes
    {
        CM = null;
        PM = null;
        DebugMenu DB = GetComponent<DebugMenu>();
        DB.enabled = !DB.enabled;

        SaveGame();

        SceneManager.LoadScene(scene); // Loads the designated Scene

        Scene currentScene = SceneManager.GetActiveScene(); // grabs the active scene to check

        if (currentScene.name == master) // Checks to see if the master scene is loaded, if so, enables all customer interaction prototype scripts
        {
            // Enables All Customer Interaction Scripts
            CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>(); // links the game manager to customer manager
            PM = GetComponent<PauseManager>();
            DB.enabled = DB.enabled;

            // Enables the Start of a Shift
            StartShift();
        }


    }


    public void StartShift()
    {
        shiftFinished = false;
        shiftStarted = true;
    }

    public void EndShift()
    {
        shiftStarted = false;
        shiftFinished = true;

        LoadScene("End Of Shift");
    }

} 

[Serializable]
class PlayerData
{
    public float playerGold;
    public float foodPercentage;
    public string savedScene;
}