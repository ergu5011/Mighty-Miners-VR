using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralData : MonoBehaviour
{
    public PlayerStatistics value;

    private AudioClip sound;

    public float hitValue;
    public float destroyValue;

    private void Start()
    {
        //AudioClip = GetComponent<>
    }

    public void OnHit()
    {
        value.score += hitValue;
    } 
    
    public void OnDestroyed()
    {
        value.score += destroyValue;
    }
}
