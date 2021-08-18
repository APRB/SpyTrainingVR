using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP4 : MonoBehaviour
{
    public Transform spawnPoint4;

    public GameObject Target4;

    public static bool t4Alive = false;

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

        if (t4Alive == false)
        {
            if (Shooting_GameManager.startGame)
            {
                timer -= Time.deltaTime;

                if (timer <= 0.0f)
                {
                    Target4.transform.position = new Vector3(spawnPoint4.transform.position.x, spawnPoint4.transform.position.y, spawnPoint4.transform.position.z);
                    Target4.SetActive(true);
                    t4Alive = true;
                }
            }
        }
    }
}
