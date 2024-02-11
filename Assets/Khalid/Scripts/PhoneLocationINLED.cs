using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneLocationINLED : MonoBehaviour
{
    public PlayMenuTransitions transitions;
    public TaskEnableDisable taskenabledisabled;
    
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Screen" && TaskTracker.currentTaskID==5)
        {

            transitions.PlayMenuAnimation(6);
            TaskTracker.currentTaskID++;
            taskenabledisabled.DisplayStep7();

        }

    }

}
