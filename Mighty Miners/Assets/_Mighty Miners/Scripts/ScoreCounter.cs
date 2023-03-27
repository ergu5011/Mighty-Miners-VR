using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public PlayerStatistics value;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = "Gold: " + value.score + " kg";

        if (value.score >= 385)
        {
            scoreText.color = Color.green;
        }
    }
}
