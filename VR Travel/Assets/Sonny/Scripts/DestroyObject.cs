using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Script: DestroyObject
    Author: Gareth Lockett Pete Phillips
    Version: 2.0
    Description:    A simple script for picking up and destroying a collectible. Make sure the collectible object has a collider set to trigger.
                    When a GameObject, with a Rigidbody component, and tagged as Player enters the trigger, the GameObject will be destroyed.
*/

public class DestroyObject : MonoBehaviour
{
    // AudioSource.PlayClipAtPoint will play an audio clip upon the destruction of the object.

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Exit")
        {
            Destroy(this.gameObject);
            //AudioSource.PlayClipAtPoint(this.GetComponent<AudioSource>().clip, Camera.main.transform.position);
        }


    }

}
