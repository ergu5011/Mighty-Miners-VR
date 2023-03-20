using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    public Transform follow;

    void Update()
    {
        transform.position = follow.transform.position;
    }
}
