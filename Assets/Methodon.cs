using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methodon : MonoBehaviour {

	public Button BurgerButton; 
	public Button PattyButton;
	private bool IsClicked;



	public Button FriesButton; 
	public Button Cheese2Button;
	private bool IsClicked2;


    public Button HotDogButton;
    public Button SausageButton;
    private bool IsClicked3;

    public Button SandwichButton;
    public Button LettuceButton;
    private bool IsClicked4;

    public Button PotatoSoupButton;
    public Button LeekButton;
    private bool IsClicked5;

    public Button FruitSaladButton;
    public Button AppleButton;
    private bool IsClicked6;




	public void OnBurgerClick ()

	{

		IsClicked = !IsClicked;

		if (IsClicked == true) {

			PattyButton.gameObject.SetActive (false);
		} else 
		{
			PattyButton.gameObject.SetActive (true);
		}



	}


	public void OnWinstonClick ()

	{

		IsClicked = !IsClicked;

		if (IsClicked == true) {

			Cheese2Button.gameObject.SetActive (false);
		} else 
		{
			Cheese2Button.gameObject.SetActive (true);
		}



	}

    public void OnHotDogClick ()
    {
        IsClicked = !IsClicked;

        if (IsClicked == true)
        {

            SausageButton.gameObject.SetActive(false);
        }
        else
        {
            SausageButton.gameObject.SetActive(true);
        }
    }


    public void OnSandwichClick ()
    {
        IsClicked = !IsClicked;

        if (IsClicked == true)
        {

            LettuceButton.gameObject.SetActive(false);
        }
        else
        {
            LettuceButton.gameObject.SetActive(true);
        }
    }


    public void OnPotatoSoupClick ()
    {
        IsClicked = !IsClicked;

        if (IsClicked == true)
        {

            LeekButton.gameObject.SetActive(false);
        }
        else
        {
            LeekButton.gameObject.SetActive(true);
        }
    }

    public void OnFruitSaladClick ()
    {
        IsClicked = !IsClicked;

        if (IsClicked == true)
        {

            AppleButton.gameObject.SetActive(false);
        }
        else
        {
            AppleButton.gameObject.SetActive(true);
        }
    }


}
