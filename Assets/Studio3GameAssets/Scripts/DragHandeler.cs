using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {


    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

   
    
    #region IBeginDragHandler implementation


    public void OnBeginDrag(PointerEventData eventData)
    {
        
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;



        //Condition for make something happen
        if (itemBeingDragged.tag.Contains ("Mango"))
        {
            Debug.Log("Mango being Drugged");
        }

        if (itemBeingDragged.tag.Contains("Lettuce"))
        {
            Debug.Log("Mango being Drugged");
        }
        if (itemBeingDragged.tag.Contains("Mango"))
        {
            Debug.Log("Mango being Drugged");
        }
        if (itemBeingDragged.tag.Contains("Mango"))
        {
            Debug.Log("Mango being Drugged");
            if (itemBeingDragged.tag.Contains("Mango"))
            {
                Debug.Log("Mango being Drugged");
            }
            if (itemBeingDragged.tag.Contains("Mango"))
            {
                Debug.Log("Mango being Drugged");
            }
            if (itemBeingDragged.tag.Contains("Mango"))
            {
                Debug.Log("Mango being Drugged");

            }
        }



        //Instantiate();
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        
    }
    #endregion





    #region IDragHandler implementation


    public void OnDrag(PointerEventData eventData)
    {

        transform.position = Input.mousePosition;

    }
    #endregion





    #region IDragHandler implementation


    public void OnEndDrag(PointerEventData eventData)
    {

        itemBeingDragged = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if(transform.parent == startParent)
        {
        
            transform.position = startPosition;
        }

    }
    #endregion

}
