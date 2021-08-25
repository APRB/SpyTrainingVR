using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixCollider : MonoBehaviour
{

public BoxCollider BoxCollider;
    void Update()
    {
        // Place the point in box space.
    Vector3 pointBoxSpace = BoxCollider.transform.InverseTransformPoint(transform.position);

    // Compute the real bounds, not incorrectly affected by the rotation.
    Bounds correctBounds = new Bounds(BoxCollider.center, BoxCollider.size);

    bool isPointInside = correctBounds.Contains(pointBoxSpace);
    }
}
