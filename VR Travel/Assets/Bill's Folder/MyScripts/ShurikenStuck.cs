using System;
using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ShurikenStuck : MonoBehaviour
{
    private GameObject anchor = null;
    private Rigidbody rb;
    private Collider col;
    private TrailRenderer trail;
    private GameObject target;

    //public LayerMask shurikenStickable;
    public bool inAir = false;
    public float despawntime = 10f;
    public float distanceForTrail;

     
   public float distance;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();
        inAir = false;
        trail = GetComponent<TrailRenderer>();
        target = GameObject.FindWithTag("Player");
        // trail.enabled = false;
    }


    void Update()
    {
        if (inAir)
        {
          // Rotate();
        }
        
        else if (anchor != null)
        {
            transform.position = anchor.transform.position;
            transform.rotation = anchor.transform.rotation;
        }


        //enable trail emmision when far enough from player
        distance = Vector3.Distance(target.transform.position, transform.position);
        if (distance > distanceForTrail) { trail.enabled = true; trail.emitting = true;  }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (inAir && collision.gameObject.layer == 10 || inAir && collision.gameObject.layer == 12 || inAir && collision.gameObject.layer == 9)
        {
            inAir = false;
            transform.position = collision.contacts[0].point;
            
            //transform.SetParent(collision.gameObject.transform); **this conforms to the parent's scale...
            
            anchor = new GameObject("Point of contact Anchor");
            anchor.transform.position = transform.position;
            anchor.transform.rotation = transform.rotation;
           anchor.transform.parent = collision.transform;
            //this.transform.SetParent(anchor.transform);
            
            //col.isTrigger = true;
            collision.gameObject.SendMessage("Shuriken hit", SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject, despawntime);
        }
        Debug.Log("Collision Happened");
        trail.enabled = false;
    }


    void Rotate()
    {
        transform.LookAt(transform.position + rb.velocity);
    }

    public void ShurikenThrown()
    {
        Debug.Log("Threw Shuriken");
        inAir = true;
        rb.useGravity = true;
        col.isTrigger = false;

       // trail.enabled = true;
       // trail.emitting = false;
    }
    public void ShurikenGrabbed()
    {
        inAir = false;
        trail.enabled = false;
        col.isTrigger = true;
    }
}
