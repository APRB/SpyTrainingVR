using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class VelocityInteractable : XRGrabInteractable
{
   private ControllerVelocity controllerVelocity = null;
   private MeshRenderer meshRenderer = null;
    //public float getControllerVelocity;

   protected override void Awake()
   {
       base.Awake();
       meshRenderer = GetComponent<MeshRenderer>();
   }
   protected override void OnSelectEntered(SelectEnterEventArgs args)
   {
       base.OnSelectEntered(args);
       controllerVelocity = args.interactor.GetComponent<ControllerVelocity>();
   }
    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        controllerVelocity = null;
    }
    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if(isSelected)
        {
            if(updatePhase == XRInteractionUpdateOrder.UpdatePhase.Dynamic)
            {
               DoThingsUsingVelocity();
            }
            //DoThingsUsingVelocity();
        }
    }

    private void DoThingsUsingVelocity()
    {
        Vector3 velocity = controllerVelocity ? controllerVelocity.velocity : Vector3.up;
        //dothings
        //getControllerVelocity = velocity.magnitude;
         // Color color = new Color(velocity.x, velocity.y, velocity.z);
        //meshRenderer.material.color = color;
        //Debug.Log(velocity);
    }
}
