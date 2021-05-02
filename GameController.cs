using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{ 
    public void OnQuitGameClick()
    {
        Application.Quit();
    }

    public void OnExitGameClick()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
}
