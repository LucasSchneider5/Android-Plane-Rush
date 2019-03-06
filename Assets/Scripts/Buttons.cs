using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

	public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/Tailor1337");
    }

    public void Home ()
    {
        SceneManager.LoadScene(0);
    }
}
