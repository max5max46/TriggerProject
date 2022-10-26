using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerSecret : MonoBehaviour
{
    public GameObject Huh;
    public AudioSource Oh;
    public GameObject Ye;
    public MeshRenderer Bruh;
    private float Timer;
    private bool TimerTime = false;
    public Material Black;
    public Light Stop;
    public Light Go;
    private bool TriggerStopper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerTime == true)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                SceneManager.LoadScene("TriggerTest");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (TriggerStopper == false)
        {
            Huh.SetActive(true);
            Ye.SetActive(true);
            Oh.Play();
            Bruh.enabled = false;
            RenderSettings.skybox = Black;
            Stop.enabled = false;
            Go.enabled = true;
            Timer = 13;
            TimerTime = true;
            TriggerStopper = true;
        }
        
    }
}
