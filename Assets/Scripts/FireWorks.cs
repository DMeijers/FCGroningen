using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireWorks : MonoBehaviour
{
    public ParticleSystem fireworks;
    // Start is called before the first frame update
    void Start()
    {
        // fireworks = GetComponent<ParticleSystem>();
        Debug.Log(fireworks);
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(ActiveFireworks);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveFireworks(ActivateEventArgs arg)
    {
        fireworks.Play();
    }
}
