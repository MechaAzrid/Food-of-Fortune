using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    [Header("Pause Variables")]
    public bool paused;
    public GameObject pausePanel;
    public GameObject pauseButton;


	// Use this for initialization
	void Start ()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PauseGame()
    {
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0;
        paused = true;
    }

    public void UnPauseGame()
    {
        pausePanel.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
        paused = false;
    }

    public void BackToMenu()
    {
        UnPauseGame();
        GameManager.instance.LoadScene("MainMenu");
    }
}
