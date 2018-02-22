using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Methodon : MonoBehaviour {

	public Button BurgerButton; 
	public Button OtherButtons;
	private bool IsClicked;



	public Button Button2; 
	public Button ButtonIWantToChange;
	private bool IsClicked2;



	public void OnBurgerClick ()

	{

		IsClicked = !IsClicked;

		if (IsClicked == true) {

			OtherButtons.gameObject.SetActive (false);
		} else 
		{
			OtherButtons.gameObject.SetActive (true);
		}



	}


	public void OnWinstonClick ()

	{

		IsClicked = !IsClicked;

		if (IsClicked == true) {

			ButtonIWantToChange.gameObject.SetActive (false);
		} else 
		{
			ButtonIWantToChange.gameObject.SetActive (true);
		}



	}

}
