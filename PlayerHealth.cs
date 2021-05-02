using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [Header("Panel")]
    public GameObject gameOverPanel;

    [Header("Game Objects")]
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    [Header("Ints")]
    public int livesLeft = 3;
    public static int livesLeftAmount = 3;

    [Header("Bools")]
    private bool activeShip;
    public static bool isDead = false;

    [Header("Text")]
    public Text finalScore;

    void Start()
    {
        livesLeftAmount = 3;
        livesLeft = livesLeftAmount;
        heart1.SetActive(true);
        heart2.SetActive(true);
        heart3.SetActive(true);

        gameOverPanel.SetActive(false);
    }

    void Update()
    {
        livesLeft = livesLeftAmount;
        CheckLives();
    }

    private void CheckLives()
    {
        livesLeft = livesLeftAmount;
        if(livesLeft == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }

        if (livesLeft == 2)
        {
            heart3.SetActive(false);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }

        if (livesLeft == 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(true);
        }

        if (livesLeft <= 0)
        {
            livesLeft = 0;
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(false);
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
        finalScore.text = "Score: " + ScoreScript.scoreAmount.ToString();
    }
}
