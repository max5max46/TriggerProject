using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSoundEffect : MonoBehaviour
{
    public AudioSource soundToPlay;

    void OnTriggerEnter(Collider other)
    {
        soundToPlay.Play();
    }
}
