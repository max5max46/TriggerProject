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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerTime == true)
        {
            Debug.Log("Sit");
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                Debug.Log("Hit");
                SceneManager.LoadScene("TriggerTest");
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Huh.SetActive(true);
        Ye.SetActive(true);
        Oh.Play();
        Bruh.enabled = false;
        RenderSettings.skybox = Black;
        Stop.enabled = false;
        Go.enabled = true;
        Timer = 11;
        TimerTime = true;
    }
}