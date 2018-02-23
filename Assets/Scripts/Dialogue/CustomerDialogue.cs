using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerDialogue : MonoBehaviour
{
    public int customerFoodValue = 0;
    public Text responseText;

    void Start()
    {
        string responseToDisplay = gameObject.GetComponent<Health.HealthResponses>().GetHealthResponse(customerFoodValue);

        responseText.text = responseToDisplay;

        //print(responseToDisplay);
    }
}
