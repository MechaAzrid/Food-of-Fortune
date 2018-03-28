using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotSlot : MonoBehaviour, IDropHandler {


    public GameObject itembeingdruggedslot;
    private IEnumerator coroutine;


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

        ////If the slot doesn't have an item
        //if (!item)
        //{
        //    //set the item dragged into the slot
        //    DragHandeler.itemBeingDragged.transform.SetParent(transform);
           
        //    //Update the text in the Canvas script gameobject
        //    ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
           
        //    //Checking what is currently dragging
        //    itembeingdruggedslot = item;
        //}

        //Preparing Mango Code
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());
            itembeingdruggedslot = item;

            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
           
        }

        //Preparing Lettuce Code
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
          
        }

        //Preparing Lettuce Code 
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            
        }

        //Preparing Carrot Code 
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
           
        }

        //Preparing Potato Code 
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
            itembeingdruggedslot.transform.GetChild(2).gameObject.SetActive(false);

        }


        //Preparing Apple Code
        if (!item && this.gameObject.tag == "ChoppingBoard")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
          
        }

        //Preparing Patty Code
        if (!item && this.gameObject.tag == "Fryer")
        {
            //itembeingdruggedslot.GetComponentInChildren<GameObject>().SetActive(false);
            itembeingdruggedslot.transform.GetChild(0).gameObject.SetActive(false);
            itembeingdruggedslot.transform.GetChild(1).gameObject.SetActive(true);
           
        }



   


    }
    #endregion





    void Update()
    {
  

    }


}



