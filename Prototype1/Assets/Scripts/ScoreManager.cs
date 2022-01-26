/*
* Zach Daly
* Assignment 2
* Controls Scoring
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    // public static can be accessed from any script...
    // ... but is hidden in the Unity Inspector
    public static bool gameOver;
    public static bool won;
    public static int score;

    // Set this in Inspector
    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Display score as long as game is not over
        if (!gameOver)
            textbox.text = "score: " + score;

        // win condition: 3 or more points
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
                textbox.text = "You Win!!\nPress R to Try Again!";
            else
                textbox.text = "You Lose!!\nPress R to Try Again!";

            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
