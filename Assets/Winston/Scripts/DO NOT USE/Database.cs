using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Database : MonoBehaviour {

    public List<ITEM> items = new List<ITEM>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

[System.Serializable]
public class ITEM
{
    public int ID;
    public string name;
    public Sprite image;

}
