using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonOnBeginDrag : MonoBehaviour, IBeginDragHandler{

    #region IBeginDragHandler implementation


    public void OnBeginDrag(PointerEventData eventData)
    {

        Debug.Log("blaaaa");
       

    }
    #endregion
}
