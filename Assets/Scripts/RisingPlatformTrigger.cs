using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatformTrigger : MonoBehaviour
{
    public GameObject Platform;
    public GameObject RiseText;
    public GameObject Secret;
    private Animator PlatformAnimation;

    // Start is called before the first frame update
    void Start()
    {
        PlatformAnimation = Platform.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        RiseText.SetActive(false);
        Secret.SetActive(false);
        PlatformAnimation.enabled = true;
    }
}
