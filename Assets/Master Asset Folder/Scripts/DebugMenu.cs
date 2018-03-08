using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenu : MonoBehaviour {

    void OnGUI()
    {
        if (GUI.Button(new Rect(1090, 100, 100, 30), "Increase Gold"))
        {
            GameManager.instance.playerGold += 10;
        }
    }   
}
