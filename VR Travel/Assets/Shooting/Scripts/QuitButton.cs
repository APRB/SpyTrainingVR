using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Debug.Log("Ran Quit Button, Load Scene Main Menu");
            //SceneManager.LoadScene("MainMenu");
        }
    }
}
