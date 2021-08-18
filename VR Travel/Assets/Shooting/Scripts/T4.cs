using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T4 : MonoBehaviour
{
    public Transform hidingSpot;
    public GameObject Target4;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //Play HitSound
            //Play Particle Effect
            SP4.t4Alive = false;
            Target4.transform.position = new Vector3(hidingSpot.transform.position.x, hidingSpot.transform.position.y, hidingSpot.transform.position.z);
            Shooting_GameManager.gameScore++;
            SetSPTimer();
            Destroy(other.gameObject);
            Target4.SetActive(false);
        }
    }

    void SetSPTimer()
    {
        float timer = Random.Range(2, 8);
        SP4.timer = timer;
    }
}
