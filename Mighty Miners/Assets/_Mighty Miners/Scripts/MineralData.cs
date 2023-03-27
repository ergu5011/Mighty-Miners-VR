using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralData : MonoBehaviour
{
    public PlayerStatistics value;

    private AudioSource hitAud, breakAud;

    [SerializeField]
    private GameObject hitSource, breakSource;

    public float hitValue;
    public float destroyValue;

    private void Start()
    {
        hitAud = hitSource.GetComponent<AudioSource>();
        breakAud = breakSource.GetComponent<AudioSource>();
    }

    public void OnHit()
    {
        value.score += hitValue;
        hitAud.Play();
    } 
    
    public void OnDestroyed()
    {
        value.score += destroyValue;
        breakAud.Play();
    }
}
