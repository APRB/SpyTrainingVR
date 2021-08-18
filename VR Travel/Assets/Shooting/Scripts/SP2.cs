using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP2 : MonoBehaviour
{
    public Transform spawnPoint2;

    public GameObject Target2;

    public static bool t2Alive = false;

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
            if (t2Alive == false)
            {
                timer -= Time.deltaTime;

                if (timer <= 0.0f)
                {
                    Target2.transform.position = new Vector3(spawnPoint2.transform.position.x, spawnPoint2.transform.position.y, spawnPoint2.transform.position.z);
                    Target2.SetActive(true);
                    t2Alive = true;
                }
            }
        }
    }
}
