using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using EzySlice;
using UnityEngine.XR.Interaction.Toolkit;

public class Slicer : MonoBehaviour
{
    public GameObject swingCheck;
    private Material materialAfterSlice;
    public Material defaultMaterial;
    public Material insideCannonball;
    public LayerMask sliceMask;
    public bool isTouched;

    public float shortTime;
    

    private void Update()
    {
        SwingCheck sc = swingCheck.GetComponent<SwingCheck>();
        if (isTouched == true && sc.sliceReady)
        {
            Collider[] newObjectsToBeSliced = Physics.OverlapBox(transform.position, new Vector3(1, 0.1f, 0.1f), transform.rotation, sliceMask);

            foreach (Collider objectToBeSliced in newObjectsToBeSliced)
            {  
                if(objectToBeSliced.tag ==("CannonBall"))
                {
                    materialAfterSlice = insideCannonball;
                }
                else
                {
                    materialAfterSlice = defaultMaterial;
                }
                SlicedHull slicedObject = SliceObject(objectToBeSliced.gameObject, materialAfterSlice);

                GameObject upperHullGameobject = slicedObject.CreateUpperHull(objectToBeSliced.gameObject, materialAfterSlice);
                GameObject lowerHullGameobject = slicedObject.CreateLowerHull(objectToBeSliced.gameObject, materialAfterSlice);
                
                if(objectToBeSliced.tag ==("CannonBall"))
                {
                    upperHullGameobject.tag = "CannonBall";
                    lowerHullGameobject.tag = "CannonBall";

                    ApplyDestroyOverTime(upperHullGameobject);
                    ApplyDestroyOverTime(lowerHullGameobject);
                }

                upperHullGameobject.transform.position = objectToBeSliced.transform.position;
                lowerHullGameobject.transform.position = objectToBeSliced.transform.position;

                MakeItPhysical(upperHullGameobject);
                MakeItPhysical(lowerHullGameobject);

                StartCoroutine(MakeItSliceableDelay(upperHullGameobject));
                StartCoroutine(MakeItSliceableDelay(lowerHullGameobject));

               // MakeItGrabable(upperHullGameobject);
                //MakeItGrabable(lowerHullGameobject);

                Destroy(objectToBeSliced.gameObject);
            }
        }
    }

    private void ApplyDestroyOverTime(GameObject obj)
    {
        obj.AddComponent<DestoyAfterTime>();
    }
    private void MakeItPhysical(GameObject obj)
    {
        obj.layer = 0;
        obj.AddComponent<MeshCollider>().convex = true;
        obj.AddComponent<Rigidbody>();
        obj.AddComponent<SlicedObject>();
    }
    
   /* private void MakeItSliceable(GameObject obj)
    {
        obj.layer = LayerMask.NameToLayer("Sliceable");
    }*/

    IEnumerator MakeItSliceableDelay(GameObject obj)
    {
        yield return new WaitForSeconds(shortTime);

        obj.layer = LayerMask.NameToLayer("Sliceable");
    }
    private void MakeItGrabable(GameObject obj)
    {
        obj.AddComponent<XRGrabInteractable>();
    }

    private SlicedHull SliceObject(GameObject obj, Material crossSectionMaterial = null)
    {
        return obj.Slice(transform.position, transform.up, crossSectionMaterial);
    }


}
