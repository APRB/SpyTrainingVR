using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP1 : MonoBehaviour
{
    public Transform spawnPoint1;

    public GameObject Target1;

    public static bool t1Alive = false;

    public static float timer;
    //exposing static to inspector for testing.
    public float timerInspector;

    private void Start()
    {
        timer = Random.Range(1, 10);
    }

    void Update()
    {
        timerInspector = timer;

        if (Shooting_GameManager.startGame)
        {
            if (t1Alive == false)
            {
                timer -= Time.deltaTime;

                if (timer <= 0.0f)
                {
                    Target1.transform.position = new Vector3(spawnPoint1.transform.position.x, spawnPoint1.transform.position.y, spawnPoint1.transform.position.z);
                    Target1.SetActive(true);
                    t1Alive = true;
                }
            }
        }
    }

}