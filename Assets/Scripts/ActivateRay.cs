using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateRay : MonoBehaviour
{
    // The right hand teleportation gameobject
    public GameObject rightTeleportation;

    // The input of hand teleportation 
    public InputActionProperty rightActive;

    // The input of hand teleportation
    public InputActionProperty rightCancel;



    // Update is called once per frame
    void Update()
    {
        // Checks if the trigger value of the teleportation is above 0.1f
        rightTeleportation.SetActive(rightCancel.action.ReadValue<float>() == 0 && rightActive.action.ReadValue<float>() > 0.1f);
    }
}
