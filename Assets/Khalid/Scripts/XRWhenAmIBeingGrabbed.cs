using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRWhenAmIBeingGrabbed : MonoBehaviour
{
    public bool iAmBeingGrabbed;


    public void BeginGrab()
    {

        iAmBeingGrabbed = true;
    }

    public void StopGrab()
    {

        iAmBeingGrabbed = false;
    }
}

