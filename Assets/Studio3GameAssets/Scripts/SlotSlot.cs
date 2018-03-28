using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotSlot : MonoBehaviour, IDropHandler {


    public GameObject itembeingdruggedslot;
    private IEnumerator coroutine;


    public AudioSource audioSourceTarget;
    public AudioClip choppingSound;
    public AudioClip fryingSound;
    public AudioClip mixingSound;


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

        //Destroy Mango Code (mixing sound)

        if (itembeingdruggedslot.tag.Contains("MangoChopped") && this.gameObject.tag == "Mixer")
        {
            
            
            audioSourceTarget.PlayOneShot(mixingSound, 0.2f);

            Destroy(itembeingdruggedslot);

        }






        //Preparing Lettuce Code
        if (itembeingdruggedslot.tag.Contains("Lettuce") && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Onion Code 
        if (itembeingdruggedslot.tag.Contains("Onion") && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Carrot Code 
        if (itembeingdruggedslot.tag.Contains("Carrot") && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Potato Code 
        if (itembeingdruggedslot.tag.Contains("Potato") && this.gameObject.tag == "ChoppingBoard" && this.gameObject.tag != "Fryer")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(false);
            itembeingdruggedslot.tag = "PotatoChopped";
            audioSourceTarget.PlayOneShot(fryingSound, 0.2f);
        }

        //Cooking Potato Code
        if (itembeingdruggedslot.tag.Contains("PotatoChopped") && this.gameObject.tag == "Fryer" && this.gameObject.tag != "ChoppingBoard" )
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }


        //Preparing Apple Code
        if (itembeingdruggedslot.tag.Contains("Apple")&& this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            audioSourceTarget.PlayOneShot(choppingSound, 0.2f);
        }

        //Preparing Patty Code
        if (itembeingdruggedslot.tag.Contains("Patty") && this.gameObject.tag == "Fryer")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
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



