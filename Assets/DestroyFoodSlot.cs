using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(FoodSlot))]
public class DestroyFoodSlot : MonoBehaviour {

	private FoodSlot foodSlot;

	private void Awake() {
		foodSlot = GetComponent<FoodSlot> ();
	}

	private void Update () {
		if (foodSlot.MyFoodItem != null) {
			Destroy (foodSlot.MyFoodItem.gameObject);
		}
	}
}