using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerStatistics value;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            value.health -= 10;
        }
    }
}
