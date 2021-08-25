using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
	public float tileSpeed = 0.5f;
	public GameObject startXPoint;
	public GameObject endXPoint;
	public float yPos = 0;
	public float zPos = 0;
	public float t = 0;


    // Update is called once per frame
    void Update()
    {
         // animate the position of the game object...
        transform.position = new Vector3(Mathf.Lerp(startXPoint.transform.position.x, endXPoint.transform.position.x, t), yPos, zPos);

        // .. and increase the t interpolater
        t += tileSpeed * Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 1.0f)
        {
            t = 0.0f;
        }
    }
}
