using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealthManager : MonoBehaviour
{
    private Collider col;
    public Material hitMat;
    Renderer rendererr;
    public EnemyController enemyCon;


    void Start()
    {
        col = GetComponent<MeshCollider>();
        rendererr = GetComponent<MeshRenderer>();
    }

  void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Shuriken")
        {
            rendererr.material = hitMat;
            enemyCon.AIDeath();
        }
    }
}
