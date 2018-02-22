using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class UnhealthyDialogue : MonoBehaviour
{
    public float customerFoodValue = 0;
    public string[] neutralResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] lowResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] midResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] maxResponses = { "Value 1", "Value 2", "Value 3" };

    //food value = x
    //x = food value of customer at the start/end of shift
    //mean of number of customers that day and their food values

    void Start()
    {
        //Dialogue to be initiated and randomised
        if (customerFoodValue == 0.0)
        {
            print(neutralResponses.RandomItem());
            //Print Randomised Neutral Responses

        }

        if (customerFoodValue <= 0.0 && customerFoodValue >= -5.0)
        {
            print(lowResponses.RandomItem());
            //Print Randomised Low Responses

        }

        if (customerFoodValue <= -6.0 && customerFoodValue >= -10.0)
        {
            print(midResponses.RandomItem());
            //Print Randomised Mid Responses

        }

        if (customerFoodValue <= -11.0 && customerFoodValue >= -15.0)
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

