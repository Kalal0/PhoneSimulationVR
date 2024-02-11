using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScreenCoverFinalStep : MonoBehaviour
{
    public WhenToMakeSataCoverActive satascript;
    public GameObject NewScreen;
    public PlayMenuTransitions transitions;
    public TaskEnableDisable taskenabledisabled;

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag.Equals("ScreenCover") && satascript.LeftScrewIsConnected==true && satascript.RightScrewIsConnected==true && TaskTracker.currentTaskID == 8)
         {
            Destroy(NewScreen.GetComponent<XRGrabInteractable>());
            Destroy(NewScreen.GetComponent<Rigidbody>());
            NewScreen.GetComponent<BoxCollider>().isTrigger = true;
            Invoke("adjustpos", 1f);
            transitions.PlayMenuAnimation(9);
            taskenabledisabled.DisplayStep10();
            
            TaskTracker.currentTaskID++;


        }

    }

    public void adjustpos()
    {
        
        NewScreen.GetComponent<SetTransform>().setNewTransform();

    }
}
