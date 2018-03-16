using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveScene : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GameManager.instance.LoadScene(GameManager.instance.savedScene);
	}
	

}
