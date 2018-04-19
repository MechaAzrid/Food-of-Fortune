using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

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




    //Timer cooking
    public float countdownCookingItem;
    public bool IsCountdownStartedForCookingItem = false;
    public Text textCountdownCookingItem;
    public GameObject textGameObjectTimerImage;
    public GameObject uIFryerGameObject;

    //Timer chooping
    public float countdownChoppingItem;
    public bool IsCountdownStartedForChoopingItem = false;
    public Text textCountdownChoppingItem;
    public GameObject textGameObjectTimerChoppingImage;
    public GameObject uIChoppingGameObject;


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
        collider2D = GetComponent<Collider2D>();
        audioSource = GetComponent<AudioSource>();

        //TimerCooking
        textCountdownCookingItem = GameObject.Find("TimerTextCook").GetComponent<Text>();
        textGameObjectTimerImage = GameObject.Find("TimerImageCook");
        textCountdownCookingItem.enabled = false;
        uIFryerGameObject = GameObject.Find("UI_Fryer");

        //TimerChooping
        textCountdownChoppingItem = GameObject.Find("TimerTextChop").GetComponent<Text>();
        textGameObjectTimerChoppingImage = GameObject.Find("TimerImageChop");
        textCountdownChoppingItem.enabled = false;
        uIChoppingGameObject = GameObject.Find("UI_ChoppingBoard");



    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if (collider2D.OverlapPoint(Input.mousePosition))
            {
                DropItem();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (collider2D.OverlapPoint(Input.mousePosition))
            {
                PickUpItem();
            }
        }

        //Timer for cooked item
        if (IsCountdownStartedForCookingItem)
        {

            
            countdownCookingItem -= Time.deltaTime;
            textCountdownCookingItem.text = string.Format("{0:#.0}", (countdownCookingItem));
            textGameObjectTimerImage.GetComponent<Image>().fillAmount += 1f / countdownCookingItem * Time.deltaTime;
            uIFryerGameObject.GetComponent<BoxCollider2D>().enabled = false;

            // countdownCookingItem.ToString();
            if (countdownCookingItem < 0)
            {
                IsCountdownStartedForCookingItem = false;
                textCountdownCookingItem.text = "0";

                MyFoodItem = MyFoodItem.Cook();
                MyFoodItem.LastSlot = this;
                IsCountdownStartedForCookingItem = false;
                countdownCookingItem = audioSource.clip.length;

                textCountdownCookingItem.enabled = false;
                uIFryerGameObject.GetComponent<BoxCollider2D>().enabled = true;


            }
        }

        //Timer for chopping item
        if (IsCountdownStartedForChoopingItem)
        {

            countdownChoppingItem -= Time.deltaTime;
            textCountdownChoppingItem.text = string.Format("{0:#.0}", (countdownChoppingItem));
            textGameObjectTimerChoppingImage.GetComponent<Image>().fillAmount += 1f / countdownChoppingItem * Time.deltaTime;
            uIChoppingGameObject.GetComponent<BoxCollider2D>().enabled = false;

            // countdownCookingItem.ToString();
            if (countdownChoppingItem < 0)
            {
                IsCountdownStartedForChoopingItem = false;
                textCountdownChoppingItem.text = "0";

                MyFoodItem = MyFoodItem.Chop();
                MyFoodItem.LastSlot = this;
                IsCountdownStartedForChoopingItem = false;
                countdownChoppingItem = audioSource.clip.length;

                textCountdownChoppingItem.enabled = false;
                uIChoppingGameObject.GetComponent<BoxCollider2D>().enabled = true;


            }
        }


    }





    public void FoodChopItem()
    {
        MyFoodItem = MyFoodItem.Chop();
        MyFoodItem.LastSlot = this;

        IsCountdownStartedForChoopingItem = false; 
        textCountdownChoppingItem.enabled = true;
        countdownChoppingItem = audioSource.clip.length;
    }

    public void FoodCookItem()
    {
        MyFoodItem = MyFoodItem.Cook();
        MyFoodItem.LastSlot = this;
        IsCountdownStartedForCookingItem = false;
        //textGameObjectTimerImage.SetActive(true);
        textCountdownCookingItem.enabled = true;
        countdownCookingItem = audioSource.clip.length;
    }






    private void DropItem()
    {
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

                    if (audioSource != null)
                    {
                        audioSource.Play();

                        IsCountdownStartedForCookingItem = true;
                        countdownCookingItem = audioSource.clip.length;
                        textCountdownCookingItem.text = countdownCookingItem.ToString();
                        // Invoke("FoodCookItem", audioSource.clip.length);

                        textCountdownCookingItem.enabled = true;

                    }
                }

                if (chopsFood)
                {

                    if (audioSource != null)
                    {
                        audioSource.Play();
                        //Debug.Log(audioSource.clip.length);


                        countdownChoppingItem = audioSource.clip.length;

                        IsCountdownStartedForChoopingItem = true;
                        textCountdownChoppingItem.text = countdownChoppingItem.ToString();
                 

                        textCountdownChoppingItem.enabled = true;

                    }
                }
            }
            else if (combinesFood)
            {
                //get the combinations from the item in the current slot. Get the item in the hand, see if there is a match
                if (audioSource != null)
                {

                    audioSource.Play();


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

                FoodItem alchemyItem = alchemyObj.GetComponent<FoodItem>();
                //if so, destroy the item in hand
                //turn the item in the slot into the new item.
                if (alchemyItem != null)
                {
                    Destroy(foodItem.gameObject);
                    MyFoodItem = alchemyItem;
                    MyFoodItem.transform.position = transform.position;
                    MyFoodItem.LastSlot = this;
                    Destroy(playerManager.HeldItem.gameObject);
                    playerManager.HeldItem = null;
                }
            }


            if (servesCustomer && MyFoodItem != null)
            {
                Debug.Log(CM.currentMeal);
                if (CM.currentMeal.mealName == MyFoodItem.FoodName)
                {
                    //Meal correct
                    Debug.Log("Correct meal");
                    GameManager.instance.playerGold += CM.currentMeal.mealCost;
                    GameManager.instance.earnedGold += CM.currentMeal.mealCost;
                    CM.OrderCorrect();
                }
                else
                {
                    //Meal incorrect
                    Debug.Log("Incorrect meal");
                    GameManager.instance.playerGold -= CM.currentMeal.mealCost;
                    GameManager.instance.earnedGold -= CM.currentMeal.mealCost;
                    CM.OrderIncorrect();
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
