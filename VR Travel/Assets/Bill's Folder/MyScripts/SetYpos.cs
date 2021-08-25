using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetYpos : MonoBehaviour
{
    public Transform myCamera;
    public GameObject belt;
    public float beltToColDistance = 3.5f;
    void Update()
    {
        //stops moving up and down the Y axis, setting it to the belt's y
       transform.position = new Vector3(myCamera.position.x, belt.transform.position.y, myCamera.position.z);

        //stops moving from going closer to player and further, locks local z pos
       // transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, beltToColDistance);

        float camRotx = myCamera.rotation.x;
        float camRotz = myCamera.rotation.x;

        float newRotx =  -camRotx;
        float newRotz =  -camRotz;
        //keeps collider facing the player when camera rotates
        // transform.eulerAngles = new Vector3(newRotx, transform.eulerAngles.y, newRotz);

        transform.eulerAngles = new Vector3(newRotx, myCamera.eulerAngles.y, newRotz);
    }
}
