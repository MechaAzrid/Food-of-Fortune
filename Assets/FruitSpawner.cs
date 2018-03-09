using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public GameObject Object;
    public Transform spawnPosition;


    GameObject cloneObject;

    public void SpawnMango()
    {

        Instantiate(Object, this.transform.position, this.transform.rotation, this.transform.parent); 


        Object.transform.parent = this.transform; 
    }
    // Update is called once per frame
    void Update () {
        
    }
}
