using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerDialogue : MonoBehaviour
{
    public int customerFoodValue = 0;

    void Start()
    {
        string responseToDisplay = gameObject.GetComponent<Health.HealthResponses>().GetHealthResponse(customerFoodValue);

        print(responseToDisplay);
    }
}
