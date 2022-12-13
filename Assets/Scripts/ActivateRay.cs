using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateRay : MonoBehaviour
{
    // The right hand teleportation gameobject
    public GameObject rightTeleportation;

    // The input of hand teleportation to activate 
    public InputActionProperty rightActive;

    // The input of hand teleportation to cancel
    public InputActionProperty rightCancel;

    // The input of hand ray
    public XRRayInteractor rightRay;



    // Update is called once per frame
    void Update()
    {
        bool isRightRayHovering = rightRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid); 
        // Checks if the trigger value of the teleportation is above 0.1f
        rightTeleportation.SetActive(!isRightRayHovering && rightCancel.action.ReadValue<float>() == 0 && rightActive.action.ReadValue<float>() > 0.1f);
    }
}
