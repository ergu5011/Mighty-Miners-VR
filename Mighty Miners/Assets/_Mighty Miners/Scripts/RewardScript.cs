using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardScript : MonoBehaviour
{
    public PlayerStatistics value;

    public GameObject[] enabledObjects;
    public GameObject disabledObjects;

    public float treshold;

    void Start()
    {
        if (value.score >= treshold)
        {
            foreach (GameObject obj in enabledObjects)
            {
                obj.SetActive(false);
            }

            disabledObjects.SetActive(true);
        }
    }
}
