using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugMenu : MonoBehaviour {

    public CustomerManager CM;

    private GUIStyle buttonStyle;
    private GUIStyle labelStyle;

    void Start()
    {
        // Setting Styles for the Debug Menu
        buttonStyle = "button"; // sets the button style to the default button
        labelStyle = "box"; // sets the label to default box type
        buttonStyle.fontSize = 30; // sets font size to 30
        buttonStyle.fontStyle = FontStyle.Bold; // sets to bold
        labelStyle.fontSize = 30; // sets font size to 30
        labelStyle.fontStyle = FontStyle.Bold; // sets to bold
    }

    void OnGUI()
    {

        // Creates the Debug Menu and spawns in all buttons
        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            GUI.Label(new Rect(5, 30, 280, 50), "Debug Menu", labelStyle); // Spawns in the Debug Menu Label
        }
        
        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 100, 280, 75), "Increase Gold 10", buttonStyle))
            {
                GameManager.instance.playerGold += 10;
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 180, 280, 75), "Decrease Gold 10", buttonStyle))
            {
                GameManager.instance.playerGold -= 10;
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 260, 280, 75), "Spawn Customer", buttonStyle))
            {
                CM.Invoke("SpawnCustomerButton", 0);
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 340, 280, 75), "Correct Order", buttonStyle))
            {
                CM.Invoke("CompleteOrderCorrectlyButton", 0);
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 420, 280, 75), "Incorrect Order", buttonStyle))
            {
                CM.Invoke("CompleteOrderIncorrectlyButton", 0);
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 500, 280, 75), "Run Average", buttonStyle))
            {
                GameManager.instance.Invoke("UpdateHealthMeter", 0);
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 580, 280, 75), "Save Game", buttonStyle))
            {
                GameManager.instance.SaveGame();
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 660, 280, 75), "Load Game", buttonStyle))
            {
                GameManager.instance.LoadGame();
            }
        }

        if (GameManager.instance.prototyping) // checks to see if prototyping is enabled
        {
            if (GUI.Button(new Rect(5, 740, 280, 75), "Clear Save", buttonStyle))
            {
                GameManager.instance.ClearSave();
            }
        }
    }   
}
