using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeveloepdByLoad : MonoBehaviour
{
    public bool loading;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine(DevelopedFade());
    }

    public void LoadMainMenu(string scene)
    {
        GameManager.instance.LoadScene(scene);
    }

    public IEnumerator DevelopedFade()
    {
        if (loading == true)
        {
            yield break;
        }

        loading = true;

        yield return new WaitForSeconds(3f);

        GameManager.instance.LoadScene("MainMenu");

        loading = false;
    }
}
