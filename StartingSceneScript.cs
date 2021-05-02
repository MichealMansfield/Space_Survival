using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingSceneScript : MonoBehaviour
{
    [Header("Game Objects")]
    public GameObject enemySpawnController;
    public GameObject collectableSpawnController;

    [Header("Panels")]
    public GameObject startingScenePanel;
    public GameObject continueText;

    [Header("Audio")]
    public AudioSource alienTalking;
    public AudioSource startLevel;
    public AudioSource music;
    public AudioClip alienTalk;

    [Header("Bools")]
    private bool spacebarPressed = false;
    public static bool gameStarted = false;

    [Header("Floats")]
    public float musicWaitTime = 5.0f;
    public float pressSpacebarWaitTime = 3.0f;

    void Start()
    {
        Time.timeScale = 1;
        continueText.SetActive(false);
        startingScenePanel.SetActive(true);
    }

    void Update()
    {
        if(SpawnScript.startingSceneActive == true)
        {
            alienTalking.Play();
            StartCoroutine(PressAnyKeyActivate());
            SpawnScript.startingSceneActive = false;
        }

        PressAnyKey();
    }

    void PressAnyKey()
    {
        if (!spacebarPressed)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                startLevel.Play();
                StartCoroutine(StartGameMusic());
                spacebarPressed = true;
                startingScenePanel.SetActive(false);
                alienTalking.Stop();
                gameStarted = true;
                enemySpawnController.SetActive(true);
                collectableSpawnController.SetActive(true);
            }
        }
    }

    IEnumerator StartGameMusic()
    {
        yield return new WaitForSeconds(musicWaitTime);
        music.Play();
    }

    IEnumerator PressAnyKeyActivate()
    {
        yield return new WaitForSeconds(pressSpacebarWaitTime);
        continueText.SetActive(true);
    }
}
