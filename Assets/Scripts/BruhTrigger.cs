using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruhTrigger : MonoBehaviour
{
    public AudioSource soundToPlay;

    void OnTriggerEnter(Collider other)
    {
        soundToPlay.enabled = true;
        soundToPlay.Play();
    }
}
