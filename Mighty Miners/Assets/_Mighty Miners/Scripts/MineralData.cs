using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralData : MonoBehaviour
{
    public PlayerStatistics value;

    public float hitValue;
    public float destroyValue;

    public void OnHit()
    {
        value.score += hitValue;
    } 
    
    public void OnDestroyed()
    {
        value.score += destroyValue;
    }
}
