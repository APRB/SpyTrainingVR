using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T5 : MonoBehaviour
{
    public Transform hidingSpot;
    public GameObject Target5;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bullet")
        {
            //Play HitSound
            //Play Particle Effect
            SP5.t5Alive = false;
            Target5.transform.position = new Vector3(hidingSpot.transform.position.x, hidingSpot.transform.position.y, hidingSpot.transform.position.z);
            Shooting_GameManager.gameScore++;
            SetSPTimer();
            Destroy(other.gameObject);
            Target5.SetActive(false);
        }
    }

    void SetSPTimer()
    {
        float timer = Random.Range(2, 8);
        SP5.timer = timer;
    }
}
