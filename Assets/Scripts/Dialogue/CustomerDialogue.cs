using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDialogue : MonoBehaviour
{
    public int customerFoodValue = 0;

    public string responseToDisplay;


    void Start()
    {
        string responseToDisplay = gameObject.GetComponent<Health.HealthResponses>().GetHealthResponse(customerFoodValue);
    }
}
