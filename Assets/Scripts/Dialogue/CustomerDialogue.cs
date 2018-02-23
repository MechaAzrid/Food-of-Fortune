using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerDialogue : MonoBehaviour
{
    [Header("Customer Food Value")]
    public int customerFoodValue = 0;

    [Header("Text Box UI")]
    public Text responseText;

    [Header("Customer Name - If Applicable")]
    public string customerName;

    void Start()
    {
        string responseToDisplay = gameObject.GetComponent<Health.HealthResponses>().GetHealthResponse(customerFoodValue);

        responseText.text = responseToDisplay;

        //responseText.text = (customerName + " : " + responseToDisplay);
            //Used if we want customers to have a name and have it show up when the text appears
    }
}
