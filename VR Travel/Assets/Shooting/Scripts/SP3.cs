using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP3 : MonoBehaviour
{
    public Transform spawnPoint3;

    public GameObject Target3;

    public static bool t3Alive = false;

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
            if (t3Alive == false)
            {
                timer -= Time.deltaTime;

                if (timer <= 0.0f)
                {
                    Target3.transform.position = new Vector3(spawnPoint3.transform.position.x, spawnPoint3.transform.position.y, spawnPoint3.transform.position.z);
                    Target3.SetActive(true);
                    t3Alive = true;
                }
            }
        }
    }
}
