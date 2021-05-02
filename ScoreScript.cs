using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [Header("Text")]
    public Text scoreAmountText;

    [Header("Ints")]
    public static int scoreAmount;
    public static int highScore;

    [Header("String")]
    public static string highScoreKey = "HighScore";

    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }

    void Update()
    {
        scoreAmountText.text = scoreAmount.ToString();
    }

    public void OnExitGame()
    {
        if(scoreAmount > PlayerPrefs.GetInt(highScoreKey, highScore))
        {
            PlayerPrefs.SetInt(highScoreKey, highScore);
        }
    }


}
