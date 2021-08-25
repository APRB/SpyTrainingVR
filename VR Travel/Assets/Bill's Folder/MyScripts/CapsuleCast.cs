using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCast : MonoBehaviour
{
    public float maxDistance;
    public float radius;
    //public Transform rotateChecker;

    public LayerMask DetectedLayer;
    public bool isInRange;
    public void Update()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction,Color.red, 200f, false);
        RaycastHit hit;

        if(Physics.Raycast(ray.origin, transform.forward, out hit, maxDistance, DetectedLayer))
        {
            if(hit.collider != null && hit.collider.gameObject.tag == "RotateCheck")
            {
                isInRange = true;
            }
            else
            {
                isInRange = false;
            }
           
        } 
            if (hit.collider == null)
            {
                isInRange = false;
            }

        
    }
}
