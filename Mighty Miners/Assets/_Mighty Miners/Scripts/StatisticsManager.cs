using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatisticsManager : MonoBehaviour
{
    public PlayerStatistics data;

    void Start()
    {
        data.score = 0;
        data.secondSpawn = true;
    }
}
