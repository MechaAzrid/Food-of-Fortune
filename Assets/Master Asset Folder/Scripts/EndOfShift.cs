using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndOfShift : MonoBehaviour {

    public Text gold;
    public Text served;
    public Text earned;

    public GameObject totalGold;
    public GameObject totalServed;
    public GameObject earnedGold;
    public GameObject startShift;
    public GameObject menu;
    public GameObject save;

    public bool loading;

	void Start ()
    {

        gold.gameObject.SetActive(false);
        served.gameObject.SetActive(false);
        earned.gameObject.SetActive(false);
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
        earned.text = "Earned Gold: " + GameManager.instance.earnedGold.ToString();
        earned.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalServed.SetActive(true);
        served.text = "Customers Served: " + GameManager.instance.customersServed.ToString();
        served.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalGold.SetActive(true);
        gold.text = "Total Gold: " + GameManager.instance.playerGold.ToString();
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
