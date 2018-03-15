using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfShift : MonoBehaviour {

    public Text gold;
    public Text served;
    public Text health;

    public GameObject totalGold;
    public GameObject totalServed;
    public GameObject totalHealth;
    public GameObject startShift;
    public GameObject menu;
    public GameObject save;

    public bool loading;

	void Start ()
    {

        gold.gameObject.SetActive(false);
        served.gameObject.SetActive(false);
        health.gameObject.SetActive(false);
        totalGold.SetActive(false);
        totalServed.SetActive(false);
        totalHealth.SetActive(false);

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

        totalGold.SetActive(true);
        gold.text = "Total Gold: " + GameManager.instance.playerGold.ToString();
        gold.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalServed.SetActive(true);
        served.text = "Customers Served: " + GameManager.instance.customersServed.ToString();
        served.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        totalHealth.SetActive(true);
        health.text = "Average Health: " + GameManager.instance.foodPercentage.ToString();
        health.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        startShift.SetActive(true);
        menu.SetActive(true);
        save.SetActive(true);

        loading = false;

        StopCoroutine(LoadResults());
    }
}
