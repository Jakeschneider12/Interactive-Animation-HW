using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour {

    void OnTriggerEnter (Collider other)
    {
      ;
        {
            SceneManager.LoadScene(0);
        }
    }

}
