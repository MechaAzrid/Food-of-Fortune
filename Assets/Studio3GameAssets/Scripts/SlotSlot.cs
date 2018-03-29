﻿using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class SlotSlot : MonoBehaviour, IDropHandler {


    public GameObject itembeingdruggedslot;
    private IEnumerator coroutine;


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



    public AudioSource audioSourceTarget;
    public AudioClip choppingSound;
    public AudioClip fryingSound;
    public AudioClip mixingSound;

    //Mixer General
    public GameObject UI_Mixer;
    public Image MixerOpen;
    public Image MixerClosed;


    //Mixer Mango + Apple
    public bool IsMangointheBox = false;
    public bool IsAppleintheBox = false;


    public GameObject item
    {

        get
        {
            if (transform.childCount > 0)
            {
                return transform.GetChild(0).gameObject;
            }
            return null;
        }


    }


    void DestroyItem()
    {

        Destroy(itembeingdruggedslot);
    }


    void Start()
    {
        MangoHierarchyPosition = GameObject.Find("Main_Mango");
        LettuceHierarchyPosition = GameObject.Find("Main_Lettuce");
        OnionHierarchyPosition = GameObject.Find("Main_Onion");
        CarrotHierarchyPosition = GameObject.Find("Main_Carrot");
        PotatoHierarchyPosition = GameObject.Find("Main_Potato");
        PattyHierarchyPosition = GameObject.Find("Patty_Main");
        AppleHierarchyPosition = GameObject.Find("Apple_Main");
        LeekHierarchyPosition = GameObject.Find("Main_Leek");
        CheeseHierarchyPosition = GameObject.Find("Main_Cheese");
        SausageHierarchyPosition = GameObject.Find("Main_Sausage");

        choppingSound = (AudioClip)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Audio/Sound Effects/Chopping SFX.wav", typeof(AudioClip));
        fryingSound = (AudioClip)UnityEditor.AssetDatabase.LoadAssetAtPath("Assets/Master Asset Folder/Audio/Sound Effects/Frying SFX.wav", typeof(AudioClip));
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
          
            itembeingdruggedslot = item;
        }

        //Preparing Mango Code
        if (itembeingdruggedslot.tag.Contains("Mango") && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);

            //Change Mango tag 
            itembeingdruggedslot.tag = "MangoChopped";

            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);



        }



        //Placing Mango in the Mixer and Wait for Apple (mixing sound)

        if (itembeingdruggedslot.tag.Contains("MangoChopped") && this.gameObject.tag == "Mixer")
        {
            
            
           // audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            //Invoke("DestroyItem",1);


            //Is mango in the box yes.
            IsMangointheBox = true;
        }

  

        // Should I make the Fruit Salad appear
        if (IsMangointheBox == true && IsAppleintheBox == true)
        {
            UI_Mixer.SetActive(false);
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
            Invoke("DestroyItem",1);
        }




        //Preparing Lettuce Code
        if (itembeingdruggedslot.tag.Contains("Lettuce") && this.gameObject.tag == "ChoppingBoard")
        {
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Onion Code 
        if (itembeingdruggedslot.tag.Contains("Onion") && this.gameObject.tag == "ChoppingBoard")
        {
            
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Carrot Code 
        if (itembeingdruggedslot.tag.Contains("Carrot") && this.gameObject.tag == "ChoppingBoard")
        {
            
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

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
        if (itembeingdruggedslot.tag.Contains("PotatoChopped") && this.gameObject.tag == "Fryer" && this.gameObject.tag != "ChoppingBoard" )
        {
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }
       
        //Preparing Leek Code
        if (itembeingdruggedslot.tag.Contains("Leek") && this.gameObject.tag == "Fryer")
        {
            
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
        }





        //Preparing Apple Code
        if (itembeingdruggedslot.tag.Contains("Apple")&& this.gameObject.tag == "ChoppingBoard")
        {
           
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);

            itembeingdruggedslot.tag = "AppleChopped";
        }


        //Destroy Apple Code (mixing sound)

        if (itembeingdruggedslot.tag.Contains("AppleChopped") && this.gameObject.tag == "Mixer")
        {


           // audioSourceTarget.PlayOneShot(mixingSound, 0.2f);
          //  Invoke("DestroyItem", 1);


            //Is mango in the box yes.
            IsAppleintheBox = true;

            itembeingdruggedslot.transform.parent = AppleHierarchyPosition.transform.parent;
        }






        //Preparing Patty Code
        if (itembeingdruggedslot.tag.Contains("Patty") && this.gameObject.tag == "Fryer")
        {
           
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
        }

        //Preparing Sausage Code
        if (itembeingdruggedslot.tag.Contains("Sausage") && this.gameObject.tag == "Fryer")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
        }




    }
    #endregion





    void Update()
    {
  

    }


}



