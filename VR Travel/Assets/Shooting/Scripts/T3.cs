using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T3 : MonoBehaviour
{
    public Transform hidingSpot;
    public GameObject Target3;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //Play HitSound
            //Play Particle Effect
            SP3.t3Alive = false;
            Target3.transform.position = new Vector3(hidingSpot.transform.position.x, hidingSpot.transform.position.y, hidingSpot.transform.position.z);
            Shooting_GameManager.gameScore++;
            SetSPTimer();
            Destroy(other.gameObject);
            Target3.SetActive(false);
        }
    }

    void SetSPTimer()
    {
        float timer = Random.Range(2, 8);
        SP3.timer = timer;
    }
}
