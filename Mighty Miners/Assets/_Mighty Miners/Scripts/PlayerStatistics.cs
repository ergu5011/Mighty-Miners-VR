using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Player Statistics")]
public class PlayerStatistics : ScriptableObject
{
    public float health;
    public float score;
    public bool secondSpawn = false;
}
