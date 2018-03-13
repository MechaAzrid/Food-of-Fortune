using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberChange : MonoBehaviour{

    public GameObject UIButtonPlus;
    public GameObject UIButtonMinus;


    
    public Text CenterText;

    public int numberText;
    
    void Start()
    {
       
    }

    public void ClickPlus()
    {
        //numberText.ToString();
        CenterText.text = numberText.ToString() ;
        numberText += 1;

    }

    public void ClickMinus()
    {
        CenterText.text = numberText.ToString();
        numberText -= 1;
    }


    void Update()
    {
        
    }




}
