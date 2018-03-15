using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour {
    //prefabs
    public GameObject MangoButton;
    public GameObject OnionButton;
    public GameObject LettuceButton;
    public GameObject PotatoButton;
    public GameObject HamburgerButton;
    public GameObject AppleButton;
    public GameObject ShallotButton;
    public GameObject CarrotButton;
    public GameObject CheeseButton;
    public GameObject SausageButton;

    //Hierachy button position
    public GameObject MangoButtonHierarchy;
    public GameObject OnionButtonHierarchy;
    public GameObject LettuceButtonHierarchy;
    public GameObject PotatoButtonHierarchy;
    public GameObject HamburgerButtonHierarchy;
    public GameObject AppleButtonHierarchy;
    public GameObject ShallotButtonHierarchy;
    public GameObject CarrotButtonHierarchy;
    public GameObject CheeseButtonHierarchy;
    public GameObject SausageButtonHierarchy;





    // Use this for initialization
    void Start () {
		
	}

    public void ButtonMango()
    {
        Instantiate(MangoButton, MangoButton.transform.position, MangoButton.transform.rotation, MangoButtonHierarchy.transform.parent);
    }   

    public void ButtonOnion()
    {
        Instantiate(OnionButton, OnionButton.transform.position, OnionButton.transform.rotation, OnionButtonHierarchy.transform.parent);

    }
    public void ButtonLettuce()
    {

        Instantiate(LettuceButton, LettuceButtonHierarchy.transform.position, LettuceButtonHierarchy.transform.rotation, LettuceButtonHierarchy.transform.parent);
    }
    public void ButtonPotato()
    {
        Instantiate(PotatoButton, PotatoButtonHierarchy.transform.position, PotatoButtonHierarchy.transform.rotation, PotatoButtonHierarchy.transform.parent);

    }
    public void ButtonHamburger()
    {
        Instantiate(HamburgerButton, HamburgerButtonHierarchy.transform.position, HamburgerButtonHierarchy.transform.rotation, HamburgerButtonHierarchy.transform.parent);

    }
    public void ButtonApple()
    {

        Instantiate(AppleButton, AppleButtonHierarchy.transform.position, AppleButtonHierarchy.transform.rotation, AppleButtonHierarchy.transform.parent);
    }
    public void ButtonShallot()
    {
        Instantiate(ShallotButton, ShallotButtonHierarchy.transform.position, ShallotButtonHierarchy.transform.rotation, ShallotButtonHierarchy.transform.parent);

    }
    public void ButtonCarrot()
    {
        Instantiate(CarrotButton, CarrotButtonHierarchy.transform.position, CarrotButtonHierarchy.transform.rotation, CarrotButtonHierarchy.transform.parent);

    }
    public void ButtonCheese()
    {
        Instantiate(CheeseButton, CheeseButtonHierarchy.transform.position, CheeseButtonHierarchy.transform.rotation, CheeseButtonHierarchy.transform.parent);

    }
    public void ButtonSausage()
    {
        Instantiate(SausageButton, SausageButtonHierarchy.transform.position, SausageButtonHierarchy.transform.rotation, SausageButtonHierarchy.transform.parent);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
