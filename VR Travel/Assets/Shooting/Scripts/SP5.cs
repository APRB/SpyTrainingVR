using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP5 : MonoBehaviour
{
    public Transform spawnPoint5;

    public GameObject Target5;

    public static bool t5Alive = false;

    public static float timer;
    //exposing static to inspector for testing.
    public float timerInspector;

    private void Start()
    {
        timer = Random.Range(1, 10);
    }
    private void Update()
    {
        timerInspector = timer;

        if (Shooting_GameManager.startGame)
        {
            if (t5Alive == false)
            {
                timer -= Time.deltaTime;

                if (timer <= 0.0f)
                {
                    Target5.transform.position = new Vector3(spawnPoint5.transform.position.x, spawnPoint5.transform.position.y, spawnPoint5.transform.position.z);
                    Target5.SetActive(true);
                    t5Alive = true;
                }
            }
        }
    }
}
