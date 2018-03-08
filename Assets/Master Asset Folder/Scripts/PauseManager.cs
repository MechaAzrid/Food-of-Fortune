using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    [Header("Pause Variables")]
    public bool paused;
    public GameObject pausePanel;


	// Use this for initialization
	void Start ()
    {
        pausePanel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        paused = true;
    }

    public void UnPauseGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        paused = false;
    }
}
