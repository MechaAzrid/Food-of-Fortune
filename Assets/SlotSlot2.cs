using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotSlot2 : MonoBehaviour,IDropHandler {
 
   

    public GameObject item2
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


    //public string itemString
    //{

    //    get
    //    {
    //        if (transform.childCount > 0)
    //        {
    //            return transform.GetChild(0).gameObject.tag;
    //        }
    //        return null;
    //    }




    //}


    #region IDropHandler implementation
    public void OnDrop(PointerEventData eventData)
    {
        if (!item2)
        {

            DragHandeler.itemBeingDragged.transform.SetParent(transform);
            ExecuteEvents.ExecuteHierarchy<IHasChanged>(gameObject, null, (x, y) => x.HasChanged());

        }
        else
        {
            

        }
    }
    #endregion


    void Update()
    {

     //   Debug.Log(itemString);
       // Debug.Log(item);
      
    }


}
