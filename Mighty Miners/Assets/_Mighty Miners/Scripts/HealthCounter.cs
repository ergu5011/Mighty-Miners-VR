using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthCounter : MonoBehaviour
{
    public PlayerStatistics value;
    public TMP_Text healthText;

    private void Start()
    {
        //value.health = 0;
    }

    void Update()
    {
        healthText.text = "Health: " + value.health;
    }
}