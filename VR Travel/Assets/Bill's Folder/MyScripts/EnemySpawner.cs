using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    public GameObject var1;

    void Update()
    {
        int random = Random.Range(0, spawnPoints.Length);
       // Debug.Log(random);

        if(var1 == null)
        {
           GameObject clone = Instantiate(enemyPrefab, spawnPoints[random]);
            var1 = clone;
        } 
    }
}
