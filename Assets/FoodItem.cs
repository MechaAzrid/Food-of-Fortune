using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItem : MonoBehaviour {
	[System.Serializable]
	public struct Combination{
		public FoodItem ingredient;
		public FoodItem result;
	}

	[SerializeField]
	private string foodName;

	[SerializeField]
	private FoodItem onCook;

	[SerializeField]
	private FoodItem onChop;

	[SerializeField]
	private Combination[] combinations;

	private FoodSlot lastSlot;

	public string FoodName {
		get { return foodName; }
	}

	public bool CanCook {
		get { return onCook != null; }
	}

	public bool CanChop
    {

        get {

            return onChop != null;

            }
	}

	public FoodSlot LastSlot {
		get { return lastSlot; }
		set { lastSlot = value; }
	}

	public void JumpToLastSlot() {
		if (LastSlot == null) {
			Destroy (gameObject);
		} else {
			lastSlot.MyFoodItem = this;
			transform.position = lastSlot.transform.position;
		}
	}

	public FoodItem GetCombination(FoodItem foodItem) {
		foreach (Combination combination in combinations) {
			if (combination.ingredient.foodName == foodItem.foodName) {
				return combination.result;
			}
		}

		return null;
	}

	public FoodItem Chop() {
		Destroy (gameObject);
		GameObject choppedItem = Instantiate (onChop.gameObject, transform.position, Quaternion.identity, transform.parent);

		return choppedItem.GetComponent<FoodItem>();
	}

	public FoodItem Cook() {
		Destroy (gameObject);
		GameObject cookedItem = Instantiate (onCook.gameObject, transform.position, Quaternion.identity, transform.parent);

		return cookedItem.GetComponent<FoodItem>();
	}
}
