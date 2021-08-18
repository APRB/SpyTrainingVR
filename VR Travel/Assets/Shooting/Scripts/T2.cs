using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T2 : MonoBehaviour
{
    public Transform hidingSpot;
    public GameObject Target2;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //Play HitSound
            //Play Particle Effect
            SP2.t2Alive = false;
            Target2.transform.position = new Vector3(hidingSpot.transform.position.x, hidingSpot.transform.position.y, hidingSpot.transform.position.z);
            Shooting_GameManager.gameScore++;
            SetSPTimer();
            Destroy(other.gameObject);
            Target2.SetActive(false);
        }
    }

    void SetSPTimer()
    {
        float timer = Random.Range(2, 8);
        SP2.timer = timer;
    }
}
