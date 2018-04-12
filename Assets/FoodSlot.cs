using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(Collider2D))]
public class FoodSlot : MonoBehaviour
{
	[SerializeField]
	private FoodItem foodItem;

	[SerializeField]
	private bool friesFood;

	[SerializeField]
	private bool chopsFood;

	[SerializeField]
	private bool combinesFood;

    [SerializeField]
    private bool servesCustomer;

	[SerializeField]
	private FoodItem trashItem;

	private AudioSource audioSource;

	private Collider2D collider2D;

    public CustomerManager CM;

    public GameObject closedBox;

	public FoodItem MyFoodItem
    {
		get
        { 
			return foodItem; 
		}
		set
        { 
			foodItem = value;
		}
	}

	private void Awake()
    {
		collider2D = GetComponent<Collider2D> ();
		audioSource = GetComponent<AudioSource> ();


	}

	private void Update()
    {
		if (Input.GetMouseButtonUp(0))
        {
			if(collider2D.OverlapPoint(Input.mousePosition))
            {
				DropItem();
			}
		}

		if (Input.GetMouseButtonDown (0))
        {
			if (collider2D.OverlapPoint (Input.mousePosition))
            {
				PickUpItem ();
			}
		}


       // Debug.Log(audioSource.clip.length);
    }

	private void DropItem() {
		PlayerManager playerManager = FindObjectOfType<PlayerManager>();

		if (playerManager != null && playerManager.HeldItem != null)
        {

			if (friesFood && !playerManager.HeldItem.CanCook)
            {
				return;
			}

			if (chopsFood && !playerManager.HeldItem.CanChop)
            {
				return;
			}

			/*if (combinesFood != playerManager.HeldItem.CanCombine) {
				return;
			}*/

			if (MyFoodItem == null)
            {
				MyFoodItem = playerManager.HeldItem;
				MyFoodItem.transform.position = transform.position;
				playerManager.HeldItem = null;
				MyFoodItem.LastSlot = this;

				//You'll want to add a timer for animations.
				if (friesFood)
                {
					MyFoodItem = MyFoodItem.Cook ();
					MyFoodItem.LastSlot = this;
					if (audioSource != null)
                    {
						audioSource.Play ();
                     
                       
					}
				}

				if (chopsFood)
                {
					MyFoodItem = MyFoodItem.Chop ();
					MyFoodItem.LastSlot = this;
					if (audioSource != null)
                    {
						audioSource.Play ();
					}
				}
			} else if (combinesFood) {
				//get the combinations from the item in the current slot. Get the item in the hand, see if there is a match
				if (audioSource != null)
                {

					audioSource.Play ();
                    closedBox.SetActive(true);
				}

                else
                {
                    closedBox.SetActive(false);
                }

				FoodItem foodPrefab = MyFoodItem.GetCombination(playerManager.HeldItem);

				if (foodPrefab == null)
                {
					foodPrefab = trashItem;
				}

				GameObject alchemyObj = Instantiate(
					foodPrefab.gameObject,
					MyFoodItem.transform.position,
					Quaternion.identity,
					playerManager.Canvas.transform
				);

				if (alchemyObj == null)
                {
					return;
				}

				FoodItem alchemyItem = alchemyObj.GetComponent<FoodItem> ();
				//if so, destroy the item in hand
				//turn the item in the slot into the new item.
				if (alchemyItem != null)
                {
					Destroy (foodItem.gameObject);
					MyFoodItem = alchemyItem;
					MyFoodItem.transform.position = transform.position;
					MyFoodItem.LastSlot = this;
					Destroy (playerManager.HeldItem.gameObject);
					playerManager.HeldItem = null;
				}
			}


			if (servesCustomer && MyFoodItem != null) {
				Debug.Log (CM.currentMeal);
				if (CM.currentMeal.mealName == MyFoodItem.FoodName) {
					//Meal correct
					Debug.Log("Correct meal");
					GameManager.instance.playerGold += CM.currentMeal.mealCost;
					GameManager.instance.earnedGold += CM.currentMeal.mealCost;
					CM.OrderCorrect ();
				} else {
					//Meal incorrect
					Debug.Log("Incorrect meal");
					GameManager.instance.playerGold -= CM.currentMeal.mealCost;
					GameManager.instance.earnedGold -= CM.currentMeal.mealCost;
					CM.OrderIncorrect ();
				}
			}
		}
	}

	private void PickUpItem()
    {
		if (MyFoodItem == null)
        {
			return;
		}

		PlayerManager playerManager = FindObjectOfType<PlayerManager>();

		if (playerManager != null && playerManager.HeldItem == null)
        {
			playerManager.HeldItem = MyFoodItem;
			MyFoodItem = null;
		}
	}


}
