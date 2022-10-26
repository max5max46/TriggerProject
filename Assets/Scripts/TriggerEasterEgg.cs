using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEasterEgg : MonoBehaviour
{
    private int Collect = 0;
    void OnTriggerEnter(Collider other)
    {
        switch (Collect)
        {
            case 0:
                Collect += 1;
                transform.position = new Vector3(-19.3691f, 2.678333f, 57.83424f);
                break;
            case 1:
                Collect += 1;
                transform.position = new Vector3(-19.3691f, 2.678333f, 28.83366f);
                break;
            case 2:
                Collect += 1;
                transform.position = new Vector3(12.63154f, 2.678333f, 28.83366f);
                break;
            case 3:
                Collect += 1;
                transform.position = new Vector3(3.368779f, 2.678333f, -24.1674f);
                break;
            case 4:
                Debug.Log("Hit");
                break;
        }
    }
}
