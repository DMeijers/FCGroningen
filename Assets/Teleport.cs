using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class Teleport : MonoBehaviour
{
    
    public int sceneIndex = 1;
    
    // Update is called once per frame
    public void PickedUp()
    {
        Debug.Log("stuff works");
        SceneManager.LoadScene(sceneIndex);
    }
}
