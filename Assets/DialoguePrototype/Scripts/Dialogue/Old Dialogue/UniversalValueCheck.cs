using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UniversalValueCheck : MonoBehaviour
{
    [Header("Reference Script")]
    public CustomerDialogue[] customerDialogue;

    [Header("Check Customer")]
    private bool hasCustomerBeenChecked;

    [Header("Customer Response Values")]
    public string[] neutralResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] lowResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] midResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] maxResponses = { "Value 1", "Value 2", "Value 3" };

    public string[] uhmidResponses = { "Value 1", "Value 2", "Value 3" };

    void Start()
    {
        customerDialogue[0] = GameObject.FindObjectOfType<CustomerDialogue>();


        // --------------------- Healthy Value Check ---------------------

        if (customerDialogue[0].customerFoodValue == 0.0)
        {
            print(neutralResponses.RandomItem());
            //Print Randomised Neutral Responses

        }

        if (customerDialogue[0].customerFoodValue > 0.0 && customerDialogue[0].customerFoodValue <= 5.0)
        {
            print(lowResponses.RandomItem());
            //Print Randomised Low Responses

            hasCustomerBeenChecked = true;
                    
                if (customerDialogue[0] && hasCustomerBeenChecked == true)
                {
                    customerDialogue[0].gameObject.SetActive(false);
                    customerDialogue[1].gameObject.SetActive(true);

            }

        }

        if (customerDialogue[0].customerFoodValue >= 6.0 && customerDialogue[0].customerFoodValue <= 10.0)
        {
            print(midResponses.RandomItem());
            //Print Randomised Mid Responses

        }

        if (customerDialogue[0].customerFoodValue >= 11.0 && customerDialogue[0].customerFoodValue <= 15.0)
        {
            print(maxResponses.RandomItem());
            //Print Randomised Max Responses

        }

        // --------------------- Unhealthy Value Check ---------------------

        if (customerDialogue[1].customerFoodValue == 0.0)
        {
            print(neutralResponses.RandomItem());
            //Print Randomised Neutral Responses

        }

        if (customerDialogue[1].customerFoodValue < 0.0 && customerDialogue[1].customerFoodValue >= -5.0)
        {
            print(lowResponses.RandomItem());
            //Print Randomised Low Responses

        }

        if (customerDialogue[1].customerFoodValue <= 6.0 && customerDialogue[1].customerFoodValue >= 10.0)
        {
            print(uhmidResponses.RandomItem());
            //Print Randomised Mid Responses
        }

        if (customerDialogue[1].customerFoodValue <= -11.0 && customerDialogue[1].customerFoodValue >= -15.0)
        {
            print(maxResponses.RandomItem());
            //Print Randomised Max Responses

        }
    }
}

public static class ArrayExtensions
{
    // This is an extension method. RandomItem() will now exist on all arrays.
    public static T RandomItem<T>(this T[] array)
    {
        return array[Random.Range(0, array.Length)];
    }
}
