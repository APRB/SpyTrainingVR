using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiStuck : ShurikenStuck
{
    private Rigidbody rbody;

    private void Awake()
    {
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(inAir)
        {
           // transform.forward = rbody.velocity;
        }
    }
}
