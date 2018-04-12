using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomerDialogue : MonoBehaviour
{
    [Header("Customer Food Value")]
    //public int customerFoodValue = 0; IGNORE

    public bool textDisplayed;

    [Header("Text Box UI")]
    public Text responseText;
    public Image speechBubble;

    [Header("Audio Clip")]
    public AudioClip popUp;
    AudioSource audio;

    [Header("Customer Name - If Applicable")]
    public string customerName;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        //Seek out the component AudioSource from the CM

        responseText.text = "";
        speechBubble.gameObject.SetActive(false);
    }

    public void UpdateText()
    {
        textDisplayed = true;

        StartCoroutine(DialogueDelay());

        //string responseToDisplay = gameObject.GetComponent<Health.HealthyResponses>().GetHealthResponse(foodPercentage);
        //responseText.text = responseToDisplay;
                //These were moved down to the Coroutine


        //responseText.text = (customerName + " : " + responseToDisplay);
        //Used if we want customers to have a name and have it show up when the text appears
    }

    public IEnumerator DialogueDelay()
    {
        yield return new WaitForSeconds(1.5f);
        //Wait 1.5F before initiliazing the dialogue

        float foodPercentage = GameManager.instance.foodPercentage;
        //Reference the GM to figure out the customers foodpercentage

        string responseToDisplay = gameObject.GetComponent<Health.HealthyResponses>().GetHealthResponse(foodPercentage);
        //Based on the above depending on what the customers foodpercentage is, use the dictionary set in the HealthyResponses to determine the dialogue value and dialogue itself

        speechBubble.gameObject.SetActive(true);
        //When the coroutine has started and the foodpercentage has been determined enable the speech bubble UI

        audio.PlayOneShot(popUp);
        //Play our AudioClip only once

        responseText.text = responseToDisplay;
        //Display the text

        StopCoroutine(DialogueDelay());
    }
}
