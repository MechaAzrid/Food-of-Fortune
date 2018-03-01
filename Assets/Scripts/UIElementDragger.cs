using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/* Copyright (C) Xenfinity LLC - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Bilal Itani <bilalitani1@gmail.com>, June 2017
 */

public class UIElementDragger : MonoBehaviour {

    public const string DRAGGABLE_TAG = "UIDraggable";

    public bool dragging = false;

    public Vector2 originalPosition;
    public Transform objectToDrag;
    public Image objectToDragImage;

    List<RaycastResult> hitObjects = new List<RaycastResult>();





    public GameObject ObjectToTransferIntoOtherPanel;
    public GameObject SlotAwatingObjectToBeTransfered;
    public GameObject PanelTop;
    public GameObject PanelBottom;



    private void Start()
    {
      //  InventoryTile1.transform.parent = InventoryTile2.transform;
    }





    #region Monobehaviour API

    void Update ()
    {
		if (Input.GetMouseButtonDown(0))
        {
            objectToDrag = GetDraggableTransformUnderMouse();

            if (objectToDrag != null)
            {
                dragging = true;

                objectToDrag.SetAsLastSibling();
                ObjectToTransferIntoOtherPanel = GameObject.Find(objectToDrag.name);

                originalPosition = objectToDrag.position;
                objectToDragImage = objectToDrag.GetComponent<Image>();
                objectToDragImage.raycastTarget = false;
            }
        }

        if (dragging)
        {
            objectToDrag.position = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (objectToDrag != null)
            {
                Transform objectToReplace = GetDraggableTransformUnderMouse();

                if (objectToReplace != null)
                {
                    objectToDrag.position = objectToReplace.position;

                    SlotAwatingObjectToBeTransfered = GameObject.Find(objectToReplace.name);

                    objectToReplace.position = originalPosition;


                    if (ObjectToTransferIntoOtherPanel.tag.Contains("PanelTop") )
                    {
                        ObjectToTransferIntoOtherPanel.transform.parent = PanelBottom.transform;
                        SlotAwatingObjectToBeTransfered.transform.parent = PanelTop.transform;
                        print("Moving PanelTop Guys");

              

                    }
                    if (ObjectToTransferIntoOtherPanel.tag.Contains("PanelTop") && ObjectToTransferIntoOtherPanel.transform.parent == PanelBottom)
                    {

                        ObjectToTransferIntoOtherPanel.transform.parent = PanelTop.transform;
                        SlotAwatingObjectToBeTransfered.transform.parent = PanelBottom.transform;
                    }




                    if (ObjectToTransferIntoOtherPanel.tag.Contains("PanelBottom"))
                    {
                        ObjectToTransferIntoOtherPanel.transform.parent = PanelTop.transform;
                        print("Moving PanelBottom Guys");

                    }




                    //is this child parent of PanelTop?
                    if (ObjectToTransferIntoOtherPanel.transform.parent == PanelTop)
                    {
                        
                    }

                    if (ObjectToTransferIntoOtherPanel.transform.parent == PanelBottom)
                    {

                    }




                }
                else
                {
                    objectToDrag.position = originalPosition;
                }

                objectToDragImage.raycastTarget = true;
                objectToDrag = null;
            }

            dragging = false;
        }
	}








    private GameObject GetObjectUnderMouse()
    {



        PointerEventData pointer = new PointerEventData(EventSystem.current);



        pointer.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pointer, hitObjects);

        if (hitObjects.Count <= 0)

        return null;

        return hitObjects.First().gameObject;        


    }







    private Transform GetDraggableTransformUnderMouse()
    {
        GameObject clickedObject = GetObjectUnderMouse();

        // get top level object hit
        if (clickedObject != null && clickedObject.tag.Contains(DRAGGABLE_TAG))
        {
            return clickedObject.transform;
        }

        return null;
    }

    #endregion
}
