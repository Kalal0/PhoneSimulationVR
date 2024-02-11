using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;

public class IsFinalStepComplete : MonoBehaviour
{

    public bool LeftScrewIsConnected = true;
    public bool RightScrewIsConnected = true;
    public GameObject confetti;
    public AudioSource ff14;

    public PlayMenuTransitions transitions;

    public void isBothConnected()
    {

        if (LeftScrewIsConnected == true && RightScrewIsConnected == true && TaskTracker.currentTaskID == 9)
        {

            transitions.PlayMenuAnimation(10);
            TaskTracker.currentTaskID++;
            ff14.Play();
            confetti.SetActive(true);

        }

    }


    public void LeftScrewConnected()
    {

        LeftScrewIsConnected = true;

    }

    public void LeftScrewDisconnected()
    {

        LeftScrewIsConnected = false;

    }

    public void RighttScrewConnected()
    {

        RightScrewIsConnected = true;

    }

    public void RightScrewDisconnected()
    {

        RightScrewIsConnected = false;

    }
}
