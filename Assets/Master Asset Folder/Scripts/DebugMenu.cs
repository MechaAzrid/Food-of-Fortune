using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenu : MonoBehaviour {

    public CustomerManager CM;

    private void Awake()
    {
        CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>();
    }

    void OnGUI()
    {
        GUI.Label(new Rect(2820, 60, 100, 30), "Debug Menu");

        if (GUI.Button(new Rect(2820, 100, 120, 30), "Increase Gold 10"))
        {
            GameManager.instance.playerGold += 10;
        }
        if (GUI.Button(new Rect(2820, 140, 120, 30), "Decrease Gold 10"))
        {
            GameManager.instance.playerGold -= 10;
        }
        if (GUI.Button(new Rect(2820, 180, 120, 30), "Spawn Customer"))
        {
            CM.Invoke("SpawnCustomerButton", 0);
        }

        if (GUI.Button(new Rect(2820, 220, 120, 30), "Correct Order"))
        {
            CM.Invoke("CompleteOrderCorrectlyButton", 0);
        }

        if (GUI.Button(new Rect(2820, 260, 120, 30), "Incorrect Order"))
        {
            CM.Invoke("CompleteOrderIncorrectlyButton", 0);
        }

        if (GUI.Button(new Rect(2820, 300, 120, 30), "Run Average"))
        {
            GameManager.instance.Invoke("UpdateHealthMeter", 0);
        }
    }   
}
