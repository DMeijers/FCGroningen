using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class ShowInfo : MonoBehaviour
{
    XRGrabInteractable m_InteractableBase;

    const string k_AnimTriggerDown = "TriggerDown";
    const string k_AnimTriggerUp = "TriggerUp";
    const float k_HeldThreshold = 0.1f;

    float m_TriggerHeldTime;
    bool m_TriggerDown;

    private bool canShowInfo = true;
    public GameObject infoObject;
    private bool isShowingInfo = true; 
    public Transform head;
    
    
    protected void Start()
    {
        m_InteractableBase = GetComponent<XRGrabInteractable>();
        m_InteractableBase.selectExited.AddListener(DroppedGun);
        m_InteractableBase.selectEntered.AddListener(PickedUp);
        m_InteractableBase.activated.AddListener(TriggerPulled);
        m_InteractableBase.deactivated.AddListener(TriggerReleased);
        
        infoObject.SetActive(false);
        isShowingInfo = false;
        print("nadshd");
    }

    protected void Update()
    {
        if (m_TriggerDown && canShowInfo)
        {
            canShowInfo = false;
            StartCoroutine(enableShowing());
            print("showinInfo");
            if (!isShowingInfo)
                {
                    print("ShowinginfoACtually");
                    infoObject.transform.LookAt(new Vector3 (head.position.x, infoObject.transform.position.y, head.position.z));
                    infoObject.transform.forward *= -1;
                    infoObject.SetActive(true);
                    isShowingInfo = true;
                }
                else
                {
                    infoObject.SetActive(false);
                    isShowingInfo = false;
                }
        }
    }

    private IEnumerator enableShowing()
    {
        yield return new WaitForSeconds(0.3f);
        canShowInfo = true;
    }
    void TriggerReleased(DeactivateEventArgs args)
    {
        m_TriggerDown = false;
        m_TriggerHeldTime = 0f;
    }

    void TriggerPulled(ActivateEventArgs args)
    {
        // m_Animator.SetTrigger(k_AnimTriggerDown);
      m_TriggerDown = true;
    }

    void DroppedGun(SelectExitEventArgs args)
    {
        infoObject.SetActive(false);
        isShowingInfo = false;
    }

    void PickedUp(SelectEnterEventArgs args)
    {
        infoObject.SetActive(true);
        isShowingInfo = true;
    }
    public void ShootEvent()
    {
       
    }
}
