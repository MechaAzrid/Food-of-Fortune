using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManagerScript : MonoBehaviour {

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

	// Use this for initialization
	void Start () {
		
	}

    public void ButtonMango()
    {
        Instantiate(MangoButton, MangoButton.transform.position, MangoButton.transform.rotation, MangoButton.transform.parent);
    }   

    public void ButtonOnion()
    {
        Instantiate(OnionButton, OnionButton.transform.position, OnionButton.transform.rotation, OnionButton.transform.parent);

    }
    public void ButtonLettuce()
    {

        Instantiate(LettuceButton, LettuceButton.transform.position, LettuceButton.transform.rotation, LettuceButton.transform.parent);
    }
    public void ButtonPotato()
    {
        Instantiate(PotatoButton, PotatoButton.transform.position, PotatoButton.transform.rotation, PotatoButton.transform.parent);

    }
    public void ButtonHamburger()
    {
        Instantiate(HamburgerButton, HamburgerButton.transform.position, HamburgerButton.transform.rotation, HamburgerButton.transform.parent);

    }
    public void ButtonApple()
    {

        Instantiate(AppleButton, AppleButton.transform.position, AppleButton.transform.rotation, AppleButton.transform.parent);
    }
    public void ButtonShallot()
    {
        Instantiate(ShallotButton, ShallotButton.transform.position, ShallotButton.transform.rotation, ShallotButton.transform.parent);

    }
    public void ButtonCarrot()
    {
        Instantiate(CarrotButton, CarrotButton.transform.position, CarrotButton.transform.rotation, CarrotButton.transform.parent);

    }
    public void ButtonCheese()
    {
        Instantiate(CheeseButton, CheeseButton.transform.position, CheeseButton.transform.rotation, CheeseButton.transform.parent);

    }
    public void ButtonSausage()
    {
        Instantiate(SausageButton, SausageButton.transform.position, SausageButton.transform.rotation, SausageButton.transform.parent);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
