using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public PlayerStatistics value;
    public TMP_Text scoreText;

    private void Start()
    {
        //value.score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + value.score;

        if (value.score >= 100)
        {
            scoreText.color = Color.green;
        }
    }
}
