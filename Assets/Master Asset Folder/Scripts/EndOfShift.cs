using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfShift : MonoBehaviour {

    public Text gold;
    public Text served;
    public Text health;

    public GameObject startShift;
    public GameObject menu;
    public GameObject save;

    public bool loading;

	void Start ()
    {
        gold = GetComponent<Text>();
        served = GetComponent<Text>();
        health = GetComponent<Text>();

        gold.gameObject.SetActive(false);
        served.gameObject.SetActive(false);
        health.gameObject.SetActive(false);

        startShift.SetActive(false);
        menu.SetActive(false);
        save.SetActive(false);
    }

    public IEnumerator LoadResults()
    {
        if (loading)
        {
            yield break;
        }

        loading = true;

        yield return new WaitForSeconds(1.5f);

        gold.text = GameManager.instance.playerGold.ToString();
        gold.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        served.text = GameManager.instance.customersServed.ToString();
        served.gameObject.SetActive(true);

        yield return new WaitForSeconds(1);

        health.text = GameManager.instance.foodPercentage.ToString();
        health.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.5f);

        startShift.SetActive(true);
        menu.SetActive(true);
        save.SetActive(true);

        loading = false;

        StopCoroutine(LoadResults());
    }
}
