using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocketBelt : MonoBehaviour
{
    public Transform castTarget;
    public Transform myCamera;
    public Vector3 offset;
    public float acceptableAngleRange = 45f;
    public float rotationSpeed = 15;
    public CapsuleCast capsulecast;
    // Update is called once per frame
    void Update()
    {
        transform.position = myCamera.position + Vector3.up * offset.y //belt following player based off headset
                             + Vector3.ProjectOnPlane(myCamera.right, Vector3.up) * offset.x
                             + Vector3.ProjectOnPlane(myCamera.forward, Vector3.up) * offset.z;

        float cameraAngleY = myCamera.eulerAngles.y;
        float selfAngleY = transform.eulerAngles.y;

        Vector3 lastFwd = Vector3.forward;
        float totalRotation = 0;

        
            float deltaAngle = Vector3.SignedAngle(lastFwd, transform.forward, transform.right);
            lastFwd = transform.forward;
            totalRotation += deltaAngle;
        

        if (capsulecast.isInRange == false)//(selfAngleY > cameraAngleY + 45f || selfAngleY < cameraAngleY - 45f)
        {
           //Vector3 lagBehind = new Vector3(0, cameraAngleY, 0);
            //transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, lagBehind, Time.deltaTime);

            Vector3 targetDirection = castTarget.position - transform.position;
            Vector3 newDirection = Vector3.Lerp(transform.forward, targetDirection , 1.5f * Time.deltaTime);

            transform.rotation = Quaternion.LookRotation(newDirection);
        }
    }
    /*private void Update()
    {
        Vector3 cameraAngle = new Vector3(myCamera.rotation.x, myCamera.rotation.y, myCamera.rotation.z);
       // myCamera.transform.Rotate(Vector3.up * 30 * Time.deltaTime);
    }*/
}
