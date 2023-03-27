using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSpawnCheck : MonoBehaviour
{
    public PlayerStatistics data;

    public GameObject player, pickaxe;
    public Transform playerSpawn, pickaxeSpawn;

    void Start()
    {
        if (data.secondSpawn == true)
        {
            player.transform.position = playerSpawn.position;
            pickaxe.transform.position = pickaxeSpawn.position;
        }
    }
}
