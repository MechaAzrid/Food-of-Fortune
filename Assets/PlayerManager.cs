using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	[SerializeField]
	private GameObject canvas;

	[SerializeField]
	private FoodItem heldItem;

	public GameObject Canvas{
		get {
			return canvas;
		}
	}

    //Properties
	public FoodItem HeldItem{
		get { 
            //this code always executes when you get the variable
			return heldItem; 
		}
		set { 
            //This code always excecutes when you set the variable
			//Set the new object
            //if(value == null)
            //{
            //    return;
            //}
			heldItem = value; 
		}
	}

	public bool HoldingItem{
		get { 
			return HeldItem != null; 
		}
	}

	private void Update() {
		if (heldItem != null) {
			//Make the held item follow the mouse.
			heldItem.transform.position = Input.mousePosition;
		}
	}

	private void LateUpdate() {
		if (Input.GetMouseButtonUp (0)) {

			if (heldItem != null) {
				heldItem.JumpToLastSlot ();
				//Destroy (heldItem.gameObject);
				HeldItem = null;
			}
		}
	}
}
