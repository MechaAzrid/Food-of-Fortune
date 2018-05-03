//using System.Collections;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using System;
//using UnityEngine.UI;

//public class SlotSlot : MonoBehaviour, IDropHandler {


//    public GameObject itembeingdruggedslot;
//    private IEnumerator coroutine;

//    public CustomerManager CM;

    //Box GameObject
    public GameObject Box;

<<<<<<< HEAD

    //For Instantiation Position and Rotation reference
    public GameObject MangoHierarchyPosition;
    public GameObject LettuceHierarchyPosition;
    public GameObject OnionHierarchyPosition;
    public GameObject CarrotHierarchyPosition;
    public GameObject PotatoHierarchyPosition;
    public GameObject PattyHierarchyPosition;
    public GameObject AppleHierarchyPosition;
    public GameObject LeekHierarchyPosition;
    public GameObject CheeseHierarchyPosition;
    public GameObject SausageHierarchyPosition;



    //Ingredients Public Gameobjects
    public GameObject Mango;
    public GameObject Lettuce;
    public GameObject Onion;
    public GameObject Carrot;
    public GameObject Potato;
    public GameObject Patty;
    public GameObject Apple;
    public GameObject Leek;
    public GameObject Cheese;
    public GameObject Sausage;


    //General Root for adjusting layering problem when dragging
    Canvas canvasRoot;
=======
//    public GameObject MangoHierarchyPosition;
//    public GameObject LettuceHierarchyPosition;
//    public GameObject OnionHierarchyPosition;
//    public GameObject CarrotHierarchyPosition;
//    public GameObject PotatoHierarchyPosition;
//    public GameObject PattyHierarchyPosition;
//    public GameObject AppleHierarchyPosition;
//    public GameObject LeekHierarchyPosition;
//    public GameObject CheeseHierarchyPosition;
//    public GameObject SausageHierarchyPosition;

//    //General Root for adjusting layering problem when dragging
//    Canvas canvasRoot;
>>>>>>> Millie

//    public AudioSource audioSourceTarget;
//    public AudioClip choppingSound;
//    public AudioClip fryingSound;
//    public AudioClip mixingSound;

//    //Mixer General
//    public GameObject UI_Mixer;
//    public Image MixerOpen;
//    public Image MixerClosed;


<<<<<<< HEAD
    //Mixer Mango + Apple
    public bool IsMangoChoppedintheBox = false;
    public bool IsAppleChoppedintheBox = false;
    public GameObject MangoAppleMixedPrefab;


    //Mixer Potato + Leek = PotatoSoup
    public bool isPotatoChoppedInTheBox = false;
    public bool isLeekChoppedInTheBox = false;
    public GameObject PotatoSoupMixedPrefab;


    //+ Fried Potato Boolian
    public bool IsPotatoFriedInTheBox = false;

    //Mixer Onion + Sausage = HotDog
    public bool isOnionChoppedInTheBox = false;
    public bool isSausageFriedInTheBox = false;
    public GameObject HotDogMixedPrefab;

    //Mixer Carrot + Lettuce = Sandwich
    public bool isCarrotChoppedInTheBox = false;
    public bool isLettuceChoppedInTheBox = false;
    public GameObject SandwichMixedPrefab;

    //Mixer Cheese + Potato = CheeseFries
    public bool isCheeseInTheBox = false;
    //public bool isPotatoInTheBox = false;
    public GameObject CheeseFriesMixedPrefab;

    //Mixer Patty + Cheese = Burger
    public bool isPattyInTheBox = false;


    //+ PattyFried for Burger boolian
    public bool isPattyFriedInTheBox = false;

    public GameObject BurgerMixedPrefab;

=======
//    //Mixer Mango + Apple
//    public bool IsMangointheBox = false;
//    public bool IsAppleintheBox = false;
//    public GameObject MangoAppleMixedPrefab;


//    //Mixer Potato + Leek = PotatoSoup
//    public bool isPotatoInTheBox = false;
//    public bool isLeekInTheBox = false;
//    public GameObject PotatoSoupMixedPrefab;
>>>>>>> Millie

//    //Mixer Onion + Sausage = HotDog
//    public bool isOnionInTheBox = false;
//    public bool isSausageInTheBox = false;
//    public GameObject HotDogMixedPrefab;

//    //Mixer Carrot + Lettuce = Sandwich
//    public bool isCarrotInTheBox = false;
//    public bool isLettuceInTheBox = false;
//    public GameObject SandwichMixedPrefab;

//    //Mixer Cheese + Potato = CheeseFries
//    public bool isCheeseInTheBox = false;
//    //public bool isPotatoInTheBox = false;
//    public GameObject CheeseFriesMixedPrefab;

//    //Mixer Patty + Cheese = Burger
//    public bool isPattyInTheBox = false;
    
//    public GameObject BurgerMixedPrefab;


//    //Script DragHandeler passing info
//    public DragHandeler dragHandeler;
//    public GameObject customerImagePanel;

//    public GameObject item
//    {

//        get
//        {
//            if (transform.childCount > 0)
//            {
//                return transform.GetChild(0).gameObject;
//            }
//            return null;
//        }


//    }


<<<<<<< HEAD
        //if(itembeingdruggedslot ==  )
        //{


        //}
        Destroy(itembeingdruggedslot);
=======
//    void DestroyItem()
//    {
>>>>>>> Millie

//        Destroy(itembeingdruggedslot);

//        UI_Mixer.SetActive(true);


//    }


<<<<<<< HEAD
        Mango = (GameObject)Resources.Load("IngredientsPrefabs/Main_Mango", typeof(GameObject)) as GameObject;
        Lettuce = (GameObject)Resources.Load("IngredientsPrefabs/Main_Lettuce", typeof(GameObject)) as GameObject;
        Onion = (GameObject)Resources.Load("IngredientsPrefabs/Main_Onion", typeof(GameObject)) as GameObject;
        Carrot = (GameObject)Resources.Load("IngredientsPrefabs/Main_Carrot", typeof(GameObject)) as GameObject;
        Potato = (GameObject)Resources.Load("IngredientsPrefabs/Main_Potato", typeof(GameObject)) as GameObject;
        Patty = (GameObject)Resources.Load("IngredientsPrefabs/Patty_Main", typeof(GameObject)) as GameObject;
        Apple = (GameObject)Resources.Load("IngredientsPrefabs/Apple_Main", typeof(GameObject)) as GameObject;
        Leek = (GameObject)Resources.Load("IngredientsPrefabs/Main_Leek", typeof(GameObject)) as GameObject;
        Cheese = (GameObject)Resources.Load("IngredientsPrefabs/Main_Cheese", typeof(GameObject)) as GameObject;
        Sausage = (GameObject)Resources.Load("IngredientsPrefabs/Main_Sausage", typeof(GameObject)) as GameObject;


        MangoAppleMixedPrefab = (GameObject)Resources.Load("Main_MangoAppleSalad", typeof(GameObject)) as GameObject;
        BurgerMixedPrefab = (GameObject)Resources.Load("Main_Burger", typeof(GameObject)) as GameObject; 
        PotatoSoupMixedPrefab = (GameObject)Resources.Load("Main_PotatoSoup", typeof(GameObject)) as GameObject;
        CheeseFriesMixedPrefab = (GameObject)Resources.Load("Main_CheeseFries", typeof(GameObject)) as GameObject;
        HotDogMixedPrefab = (GameObject)Resources.Load("Main_HotDog", typeof(GameObject)) as GameObject; 
        SandwichMixedPrefab = (GameObject)Resources.Load("Main_Sandwich", typeof(GameObject)) as GameObject; 

        choppingSound = (AudioClip)Resources.Load("Audio/Sound Effects/Chopping SFX", typeof(AudioClip)) as AudioClip;
        fryingSound = (AudioClip)Resources.Load("Audio/Sound Effects/Frying SFX", typeof(AudioClip)) as AudioClip;
=======
//    void Start()
//    {
//        MangoHierarchyPosition = GameObject.Find("Main_Mango");
//        LettuceHierarchyPosition = GameObject.Find("Main_Lettuce");
//        OnionHierarchyPosition = GameObject.Find("Main_Onion");
//        CarrotHierarchyPosition = GameObject.Find("Main_Carrot");
//        PotatoHierarchyPosition = GameObject.Find("Main_Potato");
//        PattyHierarchyPosition = GameObject.Find("Patty_Main");
//        AppleHierarchyPosition = GameObject.Find("Apple_Main");
//        LeekHierarchyPosition = GameObject.Find("Main_Leek");
//        CheeseHierarchyPosition = GameObject.Find("Main_Cheese");
//        SausageHierarchyPosition = GameObject.Find("Main_Sausage");

//        MangoAppleMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_MangoAppleSalad.prefab", typeof(GameObject));
//        BurgerMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_Burger.prefab", typeof(GameObject));
//        PotatoSoupMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_PotatoSoup.prefab", typeof(GameObject));
//        CheeseFriesMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_CheeseFries.prefab", typeof(GameObject));
//        HotDogMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_HotDog.prefab", typeof(GameObject));
//       // SandwichMixedPrefab = (GameObject)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Scenes/Master Scenes/prefab/New_Prefabs/PrefabsFinalProduct/Main_Sandwich.prefab", typeof(GameObject));

//      //  choppingSound = (AudioClip)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Audio/Sound Effects/Chopping SFX.wav", typeof(AudioClip));
//      //  fryingSound = (AudioClip)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Audio/Sound Effects/Frying SFX.wav", typeof(AudioClip));
>>>>>>> Millie

        
//        customerImagePanel = GameObject.Find("CustomerImage");
//        //dragHandeler = GameObject.FindGameObjectWithTag.("Ingredients").GetComponent<DragHandeler>();


//        //gameObjects = FindObjectsOfType(GameObject) as GameObject[];

//        //for (var i = 0; i < gameObjects.length; i++)
//        //{
//        //    if (gameObjects[i].name.Contains("Car"))
//        //    {
//        //        print(gameObjects[i] + "  : " + i);
//        //    }
//        //}



//        CM = GameObject.Find("_CustomerManager").GetComponent<CustomerManager>();

      

<<<<<<< HEAD
    }

    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        //If the slot doesn't have an item
        if (!item)
        {

          
            //set the item dragged into the slot
            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            //Update the text in the Canvas script gameobject
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
=======
//    }

//    #region IDropHandler implementation
//    public void OnDrop(PointerEventData eventData)
//    {
//        //If the slot doesn't have an item
//        if (!item)
//        {
//            //set the item dragged into the slot
//            DragHandeler.itemBeingDragged.transform.SetParent(transform);
//            //Update the text in the Canvas script gameobject
//            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
>>>>>>> Millie
          
//            itembeingdruggedslot = item;
//            dragHandeler = item.GetComponent<DragHandeler>();
            

//        }

//        //Preparing Mango Code
//        if (itembeingdruggedslot.tag.Contains("Mango") && this.gameObject.tag == "ChoppingBoard")
//        {
//            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);

//            //Change Mango tag 
//            itembeingdruggedslot.tag = "MangoChopped";

//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);



//        }



//        //Placing Mango in the Mixer and Wait for Apple (mixing sound)

//        if (itembeingdruggedslot.tag.Contains("MangoChopped") && this.gameObject.tag == "Mixer")
//        {


<<<<<<< HEAD
             audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            //Invoke("DestroyItem",1);
            //if (transform.childCount > 0)
            //{
            //    Destroy(item.gameObject);
            //}
            
            //Is mango in the box yes.
            IsMangoChoppedintheBox = true;
            Invoke("DestroyItem", 1);
        }
=======
//            // audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            //Invoke("DestroyItem",1);
//            //if (transform.childCount > 0)
//            //{
//            //    Destroy(item.gameObject);
//            //}
            
//            //Is mango in the box yes.
//            IsMangointheBox = true;
//        }
>>>>>>> Millie


<<<<<<< HEAD
        //Preparing Cheese Code
        if (itembeingdruggedslot.tag.Contains("Cheese") && this.gameObject.tag == "Mixer")
        {
            
            
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            // itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            // itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);

            //Change Cheese tag 
            // itembeingdruggedslot.tag = "MangoChopped";
            isCheeseInTheBox = true;
            Invoke("DestroyItem", 1);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);



        }
=======
//        // Should I make the Fruit Salad appear
//        if (IsMangointheBox == true && IsAppleintheBox == true)
//        {
//            UI_Mixer.SetActive(false);
//            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            Invoke("DestroyItem",1);
//            //itembeingdruggedslot.tag = "Mango, Chopping";
//            IsMangointheBox = false;
//            IsAppleintheBox = false;

//            Instantiate(MangoAppleMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
//            MangoAppleMixedPrefab.transform.parent = UI_Mixer.transform;
//        }


//        // Should I make the PotatoSoup appear
//        if (isPotatoInTheBox == true && isLeekInTheBox == true)
//        {
//            UI_Mixer.SetActive(false);
//            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            Invoke("DestroyItem", 1);
//            //itembeingdruggedslot.tag = "Mango, Chopping";
//            //isPotatoInTheBox = false;
//            //isLeekInTheBox = false;

//            Instantiate(PotatoSoupMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
//            PotatoSoupMixedPrefab.transform.parent = UI_Mixer.transform;
//        }



//        //Preparing Lettuce Code
//        if (itembeingdruggedslot.tag.Contains("Lettuce") && this.gameObject.tag == "ChoppingBoard")
//        {
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
//        }

//        //Preparing Onion Code 
//        if (itembeingdruggedslot.tag.Contains("Onion") && this.gameObject.tag == "ChoppingBoard")
//        {
            
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
//        }

//        //Preparing Carrot Code 
//        if (itembeingdruggedslot.tag.Contains("Carrot") && this.gameObject.tag == "ChoppingBoard")
//        {
            
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
//        }

//        //Preparing Potato Code 
//        if (itembeingdruggedslot.tag.Contains("Potato") && this.gameObject.tag == "ChoppingBoard" && this.gameObject.tag != "Fryer")
//        {
          
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(false);
//            itembeingdruggedslot.tag = "PotatoChopped";
//            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
//        }


>>>>>>> Millie





<<<<<<< HEAD





        //PotatoPreparation, Potato Mixer; Leek Preparation, Leek Mixer; PotatoSoup Boolians Code/////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////

        //Preparing Potato Code 
        if (itembeingdruggedslot.tag.Contains("Potato") && this.gameObject.tag == "ChoppingBoard" && this.gameObject.tag != "Fryer")
        {
          
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(false);
            itembeingdruggedslot.tag = "PotatoChopped";
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
        }


        //Cooking Potato Code
        if (itembeingdruggedslot.tag.Contains("PotatoChopped") && this.gameObject.tag == "Fryer" && this.gameObject.tag != "ChoppingBoard")
        {
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

            itembeingdruggedslot.tag = "PotatoFried";
        }

        //Mixer Potato Code but Potato is just Chopped
        if (itembeingdruggedslot.tag.Contains("PotatoChopped") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isPotatoChoppedInTheBox = true;

            itembeingdruggedslot.transform.parent = PotatoHierarchyPosition.transform.parent;
        }






        //Mixer Potato Code but Potato is Fried
        if (itembeingdruggedslot.tag.Contains("PotatoFried") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            IsPotatoFriedInTheBox = true;
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            

            itembeingdruggedslot.transform.parent = PotatoHierarchyPosition.transform.parent;
        }







        //Preparing Leek Code
        if (itembeingdruggedslot.tag.Contains("Leek") && this.gameObject.tag == "ChoppingBoard")
        {
            
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("LEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEK");
            itembeingdruggedslot.tag = "LeekChopped";


        }

        if (itembeingdruggedslot.tag.Contains("LeekChopped") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isLeekChoppedInTheBox = true;

            itembeingdruggedslot.transform.parent = LeekHierarchyPosition.transform.parent;
        }


        // Should I make the PotatoSoup appear
        if (isPotatoChoppedInTheBox == true && isLeekChoppedInTheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
            //isPotatoInTheBox = false;
            //isLeekInTheBox = false;

            Instantiate(PotatoSoupMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
            // PotatoSoupMixedPrefab.transform.parent = UI_Mixer.transform;
        }



        //End Region Potato Leek and PotatoSoup
        /////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////
        //



        ////
        //Preparing Lettuce Code
        if (itembeingdruggedslot.tag.Contains("Lettuce") && this.gameObject.tag == "ChoppingBoard")
        {
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

            itembeingdruggedslot.tag = "LettuceChopped";
        }


        //Mixer lettuce code
        if (itembeingdruggedslot.tag.Contains("LettuceChopped") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isLettuceChoppedInTheBox = true;

            itembeingdruggedslot.transform.parent = LettuceHierarchyPosition.transform.parent;
        }
        ////













        //Preparing Carrot Code 
        if (itembeingdruggedslot.tag.Contains("Carrot") && this.gameObject.tag == "ChoppingBoard")
        {

            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

            itembeingdruggedslot.tag = "CarrotChopped";
        }

        //Mixer Carrot code
        if (itembeingdruggedslot.tag.Contains("CarrotChopped") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isCarrotChoppedInTheBox = true;

            itembeingdruggedslot.transform.parent = CarrotHierarchyPosition.transform.parent;
        }
=======
//        //Cooking Potato Code
//        if (itembeingdruggedslot.tag.Contains("Leek") && this.gameObject.tag == "Fryer" && this.gameObject.tag != "ChoppingBoard" )
//        {
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

//            itembeingdruggedslot.tag = "PotatoChopped";


//        }

//        if (itembeingdruggedslot.tag.Contains("PotatoChopped") && this.gameObject.tag == "Mixer")
//        {


//            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            Invoke("DestroyItem", 1);
//            //GameObject.Find

//            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
//            //child.parent = null;
//            //gameObject.Destroy();

//            //Is mango in the box yes.
//           isPotatoInTheBox = true;

//            itembeingdruggedslot.transform.parent = PotatoHierarchyPosition.transform.parent;
//        }


//        //Preparing Leek Code
//        if (itembeingdruggedslot.tag.Contains("Leek") && this.gameObject.tag == "ChoppingBoard")
//        {
            
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

//            Debug.Log("LEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEK");
//            itembeingdruggedslot.tag = "LeekChopped";


//        }

//        if (itembeingdruggedslot.tag.Contains("LeekChopped") && this.gameObject.tag == "Mixer")
//        {


//            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            Invoke("DestroyItem", 1);
//            //GameObject.Find

//            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
//            //child.parent = null;
//            //gameObject.Destroy();

//            //Is mango in the box yes.
//            isLeekInTheBox = true;

//            itembeingdruggedslot.transform.parent = LeekHierarchyPosition.transform.parent;
//        }

>>>>>>> Millie





<<<<<<< HEAD
        ///////////////////////////////////

        //Preparing Apple Code
        if (itembeingdruggedslot.tag.Contains("Apple")&& this.gameObject.tag == "ChoppingBoard")
        {
=======
//        //Preparing Apple Code
//        if (itembeingdruggedslot.tag.Contains("Apple")&& this.gameObject.tag == "ChoppingBoard")
//        {
>>>>>>> Millie
           
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

//            itembeingdruggedslot.tag = "AppleChopped";
//        }


//        //Destroy Apple Code (mixing sound)

//        if (itembeingdruggedslot.tag.Contains("AppleChopped") && this.gameObject.tag == "Mixer")
//        {


//            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
//            Invoke("DestroyItem", 1);
//            //GameObject.Find

//            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
//            //child.parent = null;
//            //gameObject.Destroy();

<<<<<<< HEAD
            //Is mango in the box yes.
            IsAppleChoppedintheBox = true;
=======
//            //Is mango in the box yes.
//            IsAppleintheBox = true;
>>>>>>> Millie

//            itembeingdruggedslot.transform.parent = AppleHierarchyPosition.transform.parent;
//        }



        /////////////////////////////////////


//        //Preparing Patty Code
//        if (itembeingdruggedslot.tag.Contains("Patty") && this.gameObject.tag == "Fryer")
//        {
           
<<<<<<< HEAD
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            itembeingdruggedslot.tag = "PattyFried";
          
        }


        // Patty Fried Mixer Code
        if (itembeingdruggedslot.tag.Contains("PattyFried") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isPattyFriedInTheBox = true;

            itembeingdruggedslot.transform.parent = PattyHierarchyPosition.transform.parent;
        }



        //////////////////////////////////////////////////////////////////////////////////
        //Preparing Sausage Code
        if (itembeingdruggedslot.tag.Contains("Sausage") && this.gameObject.tag == "Fryer")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            itembeingdruggedslot.tag = "SausageFried";
        }

        //Destroy Sausage Code (mixing sound)

        if (itembeingdruggedslot.tag.Contains("SausageFried") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find
=======
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
//        }

//        //Preparing Sausage Code
//        if (itembeingdruggedslot.tag.Contains("Sausage") && this.gameObject.tag == "Fryer")
//        {
//            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
//            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
//        }


//        //Preparing CustomerCode Code
//        if (itembeingdruggedslot.tag.Contains("FruitSalad") && this.gameObject.tag == "CustomerSlot")
//        {
//            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
//            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
//            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
//            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);


//            dragHandeler.transform.parent = customerImagePanel.transform;
    
>>>>>>> Millie

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isSausageFriedInTheBox = true;

<<<<<<< HEAD
            itembeingdruggedslot.transform.parent = SausageHierarchyPosition.transform.parent;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////




        //Preparing Onion Code 
        if (itembeingdruggedslot.tag.Contains("Onion") && this.gameObject.tag == "ChoppingBoard")
        {

            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

            itembeingdruggedslot.tag = "OnionChopped";
        }


        //Destroy Onion Code (mixing sound)

        if (itembeingdruggedslot.tag.Contains("OnionChopped") && this.gameObject.tag == "Mixer")
        {


            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //GameObject.Find

            //Transform child = FindChild(gameObject, "ChildName"); //Replace "ChildName" with the child objects name.
            //child.parent = null;
            //gameObject.Destroy();

            //Is mango in the box yes.
            isOnionChoppedInTheBox = true;

            itembeingdruggedslot.transform.parent = OnionHierarchyPosition.transform.parent;
        }


        ///////////////////////////////////////////////


        /////////////////////////////////////////
        /////////////////////////////////////////////


        //Code to avoid snapping in the wrong location

        if (!itembeingdruggedslot.tag.Contains("Fried") && this.gameObject.tag == "Fryer")
        {

            Destroy(itembeingdruggedslot);
        }


        if (!itembeingdruggedslot.tag.Contains("Chopped") && this.gameObject.tag == "ChoppingBoard")
        {

            Destroy(itembeingdruggedslot);
        }

        ////////////////////////////////////////////////////
        ///////////////////////////////////////////////
        ////////////////////////////////////////





















        // Should I make the Fruit Salad appear
        if (IsMangoChoppedintheBox == true && IsAppleChoppedintheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
            IsMangoChoppedintheBox = false;
            IsAppleChoppedintheBox = false;

            Instantiate(MangoAppleMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
           // MangoAppleMixedPrefab.transform.parent = UI_Mixer.transform;
        }









        //Preparing CustomerCode Code
        if (itembeingdruggedslot.tag.Contains("FruitSalad") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;
    



                if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

                else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);
       
            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }
=======
//                if (dragHandeler.meal == CM.currentMeal)
//            {

//                CM.CompleteOrderCorrectlyButton();
//            }

//                else
//            {

//                CM.CompleteOrderIncorrectlyButton();
//            }

//            Destroy(dragHandeler);
       
//            /*
//                if (item being dragged . meal == CM.currentMeal)
//                {
//                    CM.CompleteOrderCorrectlyButton();
//                }
>>>>>>> Millie

//                else
//                {
//                    CM.CompleteOrderIncorrectlyButton()
//                }


//             */
//        }

<<<<<<< HEAD

        //Preparing CustomerCode Code (Burger
        if (itembeingdruggedslot.tag.Contains("Burger") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;




            if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

            else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);

            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }

                else
                {
                    CM.CompleteOrderIncorrectlyButton()
                }


             */
        }

        //Preparing CustomerCode Code
        if (itembeingdruggedslot.tag.Contains("HotDog") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;




            if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

            else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);

            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }

                else
                {
                    CM.CompleteOrderIncorrectlyButton()
                }


             */
        }

        //Preparing CustomerCode Code
        if (itembeingdruggedslot.tag.Contains("CheeseChips") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;




            if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

            else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);

            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }

                else
                {
                    CM.CompleteOrderIncorrectlyButton()
                }


             */
        }


        //Preparing CustomerCode Code
        if (itembeingdruggedslot.tag.Contains("PotatoSoup") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;




            if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

            else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);

            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }

                else
                {
                    CM.CompleteOrderIncorrectlyButton()
                }


             */
        }



        //Preparing CustomerCode Code
        if (itembeingdruggedslot.tag.Contains("Sandwich") && this.gameObject.tag == "CustomerSlot")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            //itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            //itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            //audioSourceTarget.PlayOneShot(fryingSound, 0.2f);

            Debug.Log("CUSTOMER SLOT FIRIINGGGGGGG");
            dragHandeler.transform.parent = customerImagePanel.transform;




            if (dragHandeler.meal == CM.currentMeal)
            {

                CM.CompleteOrderCorrectlyButton();
            }

            else
            {

                CM.CompleteOrderIncorrectlyButton();
            }

            Destroy(dragHandeler);
            Destroy(itembeingdruggedslot);

            /*
                if (item being dragged . meal == CM.currentMeal)
                {
                    CM.CompleteOrderCorrectlyButton();
                }

                else
                {
                    CM.CompleteOrderIncorrectlyButton()
                }


             */
        }















        // Should I make the Sandwich appear
        if (isCarrotChoppedInTheBox == true && isLettuceChoppedInTheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
            //isCarrotChoppedInTheBox = false;
            //isLettuceChoppedInTheBox = false;
          //  isCarrotChoppedInTheBox = false;
           // isLettuceChoppedInTheBox = false;
            Instantiate(SandwichMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
          //  SandwichMixedPrefab.transform.parent = UI_Mixer.transform;


        }






        // Should I make the HotDog appear
        if (isSausageFriedInTheBox == true && isOnionChoppedInTheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
           // isSausageFriedInTheBox = false;
           // isOnionChoppedInTheBox = false;

            Instantiate(HotDogMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
          //  HotDogMixedPrefab.transform.parent = UI_Mixer.transform;


        }




        // Should I make the CheeseFries appear
        if (IsPotatoFriedInTheBox == true && isCheeseInTheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
           // IsPotatoFriedInTheBox = false;
           // isCheeseInTheBox = false;

            Instantiate(CheeseFriesMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
         //   CheeseFriesMixedPrefab.transform.parent = UI_Mixer.transform;


        }

        // Should I make the Burger appear
        if (isPattyFriedInTheBox == true && isCheeseInTheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem", 1);
            //itembeingdruggedslot.tag = "Mango, Chopping";
          //  isPattyFriedInTheBox = false;
           // isCheeseInTheBox = false;

            Instantiate(BurgerMixedPrefab, UI_Mixer.transform.position, UI_Mixer.transform.rotation, UI_Mixer.transform);
          //  BurgerMixedPrefab.transform.parent = UI_Mixer.transform;


        }


    }
    #endregion
=======
//    }
//    #endregion
>>>>>>> Millie





//    void Update()
//    {
        
   
//        if (MangoHierarchyPosition == null)
//        {
//            MangoHierarchyPosition = GameObject.Find("Main_Mango(Clone)");

//        }
//        if (LettuceHierarchyPosition == null)
//        {
//            LettuceHierarchyPosition = GameObject.Find("Main_Lettuce(Clone)");

//        }
//        if (OnionHierarchyPosition == null)
//        {
//            OnionHierarchyPosition = GameObject.Find("Main_Onion(Clone)");

//        }
//        if (CarrotHierarchyPosition == null)
//        {
//            CarrotHierarchyPosition = GameObject.Find("Main_Carrot(Clone)");

//        }
//        if (PotatoHierarchyPosition == null)
//        {
//            PotatoHierarchyPosition = GameObject.Find("Main_Potato(Clone)");

//        }
//        if (PattyHierarchyPosition == null)
//        {
//            PattyHierarchyPosition = GameObject.Find("Patty_Main(Clone)");

//        }
//        if (AppleHierarchyPosition == null)
//        {
//            AppleHierarchyPosition = GameObject.Find("Apple_Main(Clone)");

//        }

//        if (LeekHierarchyPosition == null)
//        {
//            LeekHierarchyPosition = GameObject.Find("Main_Leek(Clone)");

//        }

//        if (CheeseHierarchyPosition == null)
//        {
//            CheeseHierarchyPosition = GameObject.Find("Main_Cheese(Clone)");

//        }
//        if (SausageHierarchyPosition == null)
//        {
//            SausageHierarchyPosition = GameObject.Find("Main_Sausage(Clone)");

//        }
       
//    }


//}



