using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject startPanel;
    public GameObject mainPanel;
    public GameObject settingsPanel;
    public GameObject controlsPanel;
    public GameObject creditsPanel;

    [Header("Buttons")]
    public GameObject startButton;
    public GameObject settingsButton;
    public GameObject creditsButton;
    public GameObject controlsButton;
    public GameObject quitButton;
    public GameObject yesQuitButton;
    public GameObject noQuitButton;

    [Header("Texts")]
    public GameObject titleText;
    public GameObject areYouSureText;

    [Header("Audio")]
    public AudioSource music;
    public AudioSource start;

    [Header("Floats")]
    public float musicWaitTime = 2.0f;

    [Header("Bools")]
    private bool anyKeyPressed = false;

    void Start()
    {
        Time.timeScale = 1;

        titleText.SetActive(true);
        areYouSureText.SetActive(false);

        startPanel.SetActive(true);
        mainPanel.SetActive(false);
        settingsPanel.SetActive(false);
        controlsPanel.SetActive(false);
        creditsPanel.SetActive(false);

        startButton.SetActive(true);
        settingsButton.SetActive(true);
        creditsButton.SetActive(true);
        controlsButton.SetActive(true);
        quitButton.SetActive(true);
        yesQuitButton.SetActive(false);
        noQuitButton.SetActive(false);
    }

    void Update()
    {
        PressAnyKey();
    }

    void PressAnyKey()
    {
        if(!anyKeyPressed)
        {
            if (Input.anyKeyDown)
            {
                startPanel.SetActive(false);
                mainPanel.SetActive(true);
                start.Play();

                StartCoroutine(StartMenuMusic());

                anyKeyPressed = true;
            }
        }
    }

    IEnumerator StartMenuMusic()
    {
        yield return new WaitForSeconds(musicWaitTime);
        music.Play();
    }

    public void OnQuitButtonClick()
    {
        titleText.SetActive(false);
        areYouSureText.SetActive(true);
        startButton.SetActive(false);
        settingsButton.SetActive(false);
        creditsButton.SetActive(false);
        controlsButton.SetActive(false);
        quitButton.SetActive(false);
        yesQuitButton.SetActive(true);
        noQuitButton.SetActive(true);
    }

    public void OnNoQuitButtonClick()
    {
        titleText.SetActive(true);
        areYouSureText.SetActive(false);
        startButton.SetActive(true);
        settingsButton.SetActive(true);
        creditsButton.SetActive(true);
        controlsButton.SetActive(true);
        quitButton.SetActive(true);
        yesQuitButton.SetActive(false);
        noQuitButton.SetActive(false);
    }

    public void OnYesQuitButtonClick()
    {
        Application.Quit();
    }

    public void ResetScene()
    {
        titleText.SetActive(true);
        areYouSureText.SetActive(false);

        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
        controlsPanel.SetActive(false);
        creditsPanel.SetActive(false);

        startButton.SetActive(true);
        settingsButton.SetActive(true);
        creditsButton.SetActive(true);
        quitButton.SetActive(true);
        yesQuitButton.SetActive(false);
        noQuitButton.SetActive(false);
    }

    public void OnBackButtonClick()
    {
        ResetScene();
    }

    public void OnSettingsButtonClick()
    {
        settingsPanel.SetActive(true);
    }

    public void OnControlsButtonClick()
    {
        controlsPanel.SetActive(true);
    }

    public void OnCreditsButtonClick()
    {
        creditsPanel.SetActive(true);
    }

    public void OnStartButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
