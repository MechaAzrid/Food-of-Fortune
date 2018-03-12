using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenu : MonoBehaviour {

    public CustomerManager CM;

    private void Awake()
    {
        CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>();
    }

    void Start()
    {
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(130, 60, 100, 30), "Debug Menu");

        if (GUI.Button(new Rect(100, 100, 120, 30), "Increase Gold 10"))
        {
            GameManager.instance.playerGold += 10;
        }
        if (GUI.Button(new Rect(100, 140, 120, 30), "Decrease Gold 10"))
        {
            GameManager.instance.playerGold -= 10;
        }
        if (GUI.Button(new Rect(100, 180, 120, 30), "Spawn Customer"))
        {
            CM.Invoke("SpawnCustomerButton", 0);
        }

        if (GUI.Button(new Rect(100, 220, 120, 30), "Correct Order"))
        {
            CM.Invoke("CompleteOrderCorrectlyButton", 0);
        }

        if (GUI.Button(new Rect(100, 260, 120, 30), "Incorrect Order"))
        {
            CM.Invoke("CompleteOrderIncorrectlyButton", 0);
        }

        if (GUI.Button(new Rect(100, 300, 120, 30), "Run Average"))
        {
            GameManager.instance.Invoke("UpdateHealthMeter", 0);
        }
    }   
}
