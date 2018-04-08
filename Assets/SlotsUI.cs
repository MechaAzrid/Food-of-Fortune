using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsUI : MonoBehaviour {

	/*[SerializeField]
	private int numberOfSlots = 10;*/

	[SerializeField]
	private GameObject slotPrefab;

	[SerializeField]
	private GameObject[] slotItems;

	private void Awake() {
		GameObject currentSlot;
		GameObject slotItem;

		for (int i = 0; i < slotItems.Length; i++) {
			currentSlot = Instantiate (slotPrefab, transform);
			slotItem = Instantiate (slotItems [i], currentSlot.transform);
		}
	}
}
