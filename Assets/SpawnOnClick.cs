using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class SpawnOnClick : MonoBehaviour {
	[SerializeField]
	private FoodItem slotItem;

	private Collider2D collider2D;

	private void Awake()
    {
		collider2D = GetComponent<Collider2D> ();
	}

	private void Update() {
		if (Input.GetMouseButtonDown(0))
        {
			if(collider2D.OverlapPoint(Input.mousePosition))
            {
				CreateItem ();
			}
		}
	}

	private void CreateItem() {
		PlayerManager playerManager = FindObjectOfType<PlayerManager>();

		if (playerManager != null)
        {
			if (playerManager.Canvas != null)
            {
				GameObject item = Instantiate (slotItem.gameObject, transform.position, Quaternion.identity, playerManager.Canvas.transform);
				playerManager.HeldItem = item.GetComponent<FoodItem>();
			}
		}
	}
}
