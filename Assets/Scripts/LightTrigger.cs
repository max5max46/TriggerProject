using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public GameObject Toad;
    public Light spotLight;
    public Light mainLight;

    void OnTriggerEnter(Collider other)
    {
        Toad.SetActive(true);
        spotLight.enabled = true;
        mainLight.enabled = false;
    }

    void OnTriggerExit(Collider other)
    {
        Toad.SetActive(false);
        spotLight.enabled = false;
        mainLight.enabled = true;
    }
}
