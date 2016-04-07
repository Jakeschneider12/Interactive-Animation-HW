using UnityEngine;
using System.Collections;

public class CameraSwitch : MonoBehaviour {

    public Camera Camera1;
    public Camera Camera2;

    void OnTriggerEnter (Collider other)
    {
        if (other.name == "Player")
        {
            Camera1.enabled = false;
            Camera2.enabled = true;
        }
    }

}
