using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoveringRaycast : MonoBehaviour {

  

    

    void Update()
    {

       
        
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // whatever tag you are looking for on your game object
                if (hit.collider.tag == "Trigger")
                {
                    Debug.Log("---> Hit: ");
                }
            }
        
    }
}
