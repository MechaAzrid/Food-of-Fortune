using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfShift : MonoBehaviour {

    public Text gold;
    public Text served;
    public Text earned;
    public Text petrol;
    public Text rent;

    public GameObject totalGold;
    public GameObject totalServed;
    public GameObject payedPetrol;
    public GameObject payedRent;
    public GameObject earnedGold;
    public GameObject startShift;
    public GameObject menu;
    public GameObject save;

    public bool loading;


    //music change
   
    public AudioSource audiomain;
    public AudioClip endShiftMusic;



    void Start ()
    {

        audiomain = GameManager.instance.GetComponent<AudioSource>();
       // audiomain = GameManager.GetComponent<AudioSource>();
        audiomain.clip = endShiftMusic;
        audiomain.Play();


        gold.gameObject.SetActive(false);
        served.gameObject.SetActive(false);
        earned.gameObject.SetActive(false);
        petrol.gameObject.SetActive(false);
        rent.gameObject.SetActive(false);
        payedPetrol.SetActive(false);
        payedRent.SetActive(false);
        totalGold.SetActive(false);
        totalServed.SetActive(false);
        earnedGold.SetActive(false);

        startShift.SetActive(false);
        menu.SetActive(false);
        save.SetActive(false);

    

        StartCoroutine(LoadResults());
    }

    public IEnumerator LoadResults()
    {
        if (loading)
        {
            yield break;
        }

        loading = true;



        yield return new WaitForSeconds(1.5f);

        earnedGold.SetActive(true);
        earned.text = "Earned Money: " + GameManager.instance.earnedGold.ToString();
        earned.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalServed.SetActive(true);
        served.text = "Customers Served: " + GameManager.instance.customersServed.ToString();
        served.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);

        payedPetrol.SetActive(true);
        petrol.text = "Petrol Paid: " + GameManager.instance.petrol.ToString();
        petrol.gameObject.SetActive(true);

        yield return new WaitForSeconds(1f);

        payedRent.SetActive(true);
        rent.text = "Rent Paid: " + GameManager.instance.rent.ToString();
        rent.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalGold.SetActive(true);
        gold.text = "Total Money: " + GameManager.instance.playerGold.ToString();
        gold.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        startShift.SetActive(true);
        menu.SetActive(true);
        save.SetActive(true);

        loading = false;

        StopCoroutine(LoadResults());
    }

    public void LoadMenu()
    {
        GameManager.instance.LoadScene("MainMenu"); // changes scene through the Game Manager
    }


    public void NewShift()
    {
        GameManager.instance.LoadScene("MenuSelectionInventory"); //changes Scene through game manager
    }
}
