using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    private Animator anim;

    private AudioSource aud;

    void Start()
    {
        anim = GetComponent<Animator>();
        aud = GetComponent<AudioSource>();
    }

    public void DoorOpen()
    {
        anim.SetBool("OpenDoor", true);
        aud.Play();
    }
    
}
