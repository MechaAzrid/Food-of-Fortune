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

	public FoodItem HeldItem{
		get { 
			return heldItem; 
		}
		set { 
			//Set the new object
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
