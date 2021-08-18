using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T1 : MonoBehaviour
{
    public Transform hidingSpot;
    public GameObject Target1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            //Play HitSound
            //Play Particle Effect
            SP1.t1Alive = false;
            Target1.transform.position = new Vector3(hidingSpot.transform.position.x, hidingSpot.transform.position.y, hidingSpot.transform.position.z);
            Shooting_GameManager.gameScore++;
            SetSPTimer();
            Destroy(other.gameObject);
            Target1.SetActive(false);
        }
    }

    void SetSPTimer()
    {
        float timer = Random.Range(2, 8);
        SP1.timer = timer;
    }
}