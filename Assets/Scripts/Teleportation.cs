using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class Teleportation : MonoBehaviour
{
    public Transform XR_Rig;

    public Transform newPosition;

    public KeyCode keyToPress = KeyCode.Space;

    private XRGrabInteractable grabInteractable;

    void Start()
    {
    }
    public void TPongrab()
    {
        XR_Rig.position = newPosition.position;
    }
    void Update()
    {
    }
}
