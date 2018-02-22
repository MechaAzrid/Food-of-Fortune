using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDialogue : MonoBehaviour
{
    public float customerFoodValue = 0;

    public string responseToDisplay;


    void Start()
    {
        string responseToDisplay = gameObject.GetComponent<>().GetHealthResponse(customerFoodValue);
    }
}
