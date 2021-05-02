using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    [Header("Panels")]
    public GameObject pausePanel;

    [Header("Audio Source")]
    public AudioSource music;

    void Start()
    {
        pausePanel.SetActive(false);
    }

    void Update()
    {
        if(StartingSceneScript.gameStarted)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                pausePanel.SetActive(true);
                music.Pause();
            }
        }
    }

    public void OnResumeButtonClick()
    {
        pausePanel.SetActive(false);
        music.Play();
        Time.timeScale = 1;
    }
}
