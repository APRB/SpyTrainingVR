using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnAfterTime : MonoBehaviour
{
    public float despawnTimer = 0.0f;

    private void Update()
    {
        despawnTimer += Time.deltaTime;
        if (despawnTimer >= 20.0f)
        {
            Destroy(gameObject);
        }
    }
    
}
