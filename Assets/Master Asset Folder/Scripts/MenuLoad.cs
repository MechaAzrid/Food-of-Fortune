using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoad : MonoBehaviour
{
    [Header("Canvas Groups")]
    public Transform mainCanvas;
    public Transform instructionsCanvas;

    [Header("Particle Systems")]
    public ParticleSystem particleSys;
    public ParticleSystem particleSys2;
    public ParticleSystem particleSys3;

    public void LoadMasterScene(string scene)
    {
        SceneManager.LoadScene("Master_Scene");
    }

    public void LoadInstructionsScene()
    {
        if (instructionsCanvas.gameObject.activeInHierarchy == false)
            //if the Instructions Canvas is inactive then when we press "Instructions" enable the canvas but disable the mainCanvas
        {
            instructionsCanvas.gameObject.SetActive(true);
            mainCanvas.gameObject.SetActive(false);
            particleSys.gameObject.SetActive(false);
            particleSys2.gameObject.SetActive(false);
            particleSys3.gameObject.SetActive(false);

        }

        else
        {
            instructionsCanvas.gameObject.SetActive(false);
            particleSys.gameObject.SetActive(true);
            particleSys2.gameObject.SetActive(true);
            particleSys3.gameObject.SetActive(true);
        }
    }

    public void ReturnToMainScene()
    {
        if (mainCanvas.gameObject.activeInHierarchy == false)
        {
            mainCanvas.gameObject.SetActive(true);
            instructionsCanvas.gameObject.SetActive(false);
            particleSys.gameObject.SetActive(true);
            particleSys2.gameObject.SetActive(true);
            particleSys3.gameObject.SetActive(true);

        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
