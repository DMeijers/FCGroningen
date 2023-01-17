using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class Teleport : MonoBehaviour
{
    
    XRGrabInteractable m_InteractableBase;
    public int sceneIndex = 1;
    
    // Start is called before the first frame update
    protected void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.selectEntered.AddListener(PickedUp);
    }
    
    // Update is called once per frame
    void PickedUp(SelectEnterEventArgs args)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
