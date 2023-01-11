using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandsAnimation : MonoBehaviour
{
    //Reference to the inputaction for the pinch
    public InputActionProperty pinchAnimation;
    //Reference to the inputaction for the grip
    public InputActionProperty gripAnimation;
    //Reference to the handAnimator
    public Animator handAnimator;

    // Update is called once per frame
    void Update()
    {
        //Reads value of the trigger and sets the new float value into the animator
        float triggerValue = pinchAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerValue);

        //Reads value of the grip and sets the new float value into the animator
        float gripValue = gripAnimation.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripValue);
    }
}
