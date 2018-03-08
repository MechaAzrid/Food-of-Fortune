using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

 
    public GameObject gun;
    public Transform ammo;

    //Invoked when a button is clicked.
    public void Example()
    {
     
    }






    //This is for getting the Children inside a parent
        int value = 0;
        private Transform[] childs;
        public GameObject[] childObjects;

    void Start()
    {
        childs = gameObject.GetComponentsInChildren<Transform>();
        childObjects = new GameObject[childs.Length];

        foreach (Transform trans in childs)
        {
            value++;
            childObjects.SetValue(trans.gameObject, value - 1);
        }
    }


    //public Transform[] ChildinParent;

    //public Transform ParentObject;

    void Update()
    {


 




        //Finds and assigns the child of the player named "Gun".
        gun = this.transform.Find("Riccio").gameObject;

        //If the child was found.
        if (gun != null)
        {
            //Find the child named "ammo" of the gameobject "magazine" (magazine is a child of "gun").
            ammo = gun.transform.Find("magazine/ammo");
        }
        else Debug.Log("No child with the name 'Gun' attached to the player");
    }
}
