using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;  // Store our score value
    public TextMeshProUGUI scoreText; // refreance visual text ui element to change


    // Start is called before the first frame update
    void Start()
    {
    
    }

    // funtcion rewards player
    public void IncreaseScore(int amount)
    {
        score += amount; //add amout to score
        UpdateScoreText(); //update the score UI text
    }
    //function penalizes score
    public void DecreaseScore(int amount)
    {
        score -= amount; //subtract amout from the score
        UpdateScoreText(); //update the score UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }
}
