using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class UnhealthyDialogue : MonoBehaviour
{
    //public float customerFoodValue = 0;

    [Header("Reference Script")]
    public CustomerDialogue customerDialogue;

    [Header("Customer Response Values")]
    public string[] neutralResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] lowResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] midResponses = { "Value 1", "Value 2", "Value 3" };
    public string[] maxResponses = { "Value 1", "Value 2", "Value 3" };

    //Food Value = x
        //x = Food Value of Customer At The Start/End of A Shift
            //Mean of The Number of Customers That Day and Their Food Values


    //Need To Have It Check What Food The Customer Ordered
        //Based On That Food Increases The Customers "customerFoodValue"
    
//    void Start()
//    {
//        //Dialogue to be initiated and randomised
//        if (customerDialogue.customerFoodValue == 0.0)
//        {
//            print(neutralResponses.RandomItem());
//            //Print Randomised Neutral Responses

//        }

//            if (customerDialogue.customerFoodValue < 0.0 && customerDialogue.customerFoodValue >= -5.0)
//            {
//                print(lowResponses.RandomItem());
//                //Print Randomised Low Responses

//            }

//                if (customerDialogue.customerFoodValue <= -6.0 && customerDialogue.customerFoodValue >= -10.0)
//                {
//                    print(midResponses.RandomItem());
//                    //Print Randomised Mid Responses

//                }

//                    if (customerDialogue.customerFoodValue <= -11.0 && customerDialogue.customerFoodValue >= -15.0)
//                    {
//                        print(maxResponses.RandomItem());
//                        //Print Randomised Max Responses

//                    }
//    }
//}

//public static class ArrayExtensions
//{
//    // This is an extension method. RandomItem() will now exist on all arrays.
//    public static T RandomItem<T>(this T[] array)
//    {
//        return array[Random.Range(0, array.Length)];
//    } 
}