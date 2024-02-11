using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isNewBatteryConnected : MonoBehaviour
{
    public bool isBatteryConnected=false;
    public bool issatacableconnected = false;

    public PlayMenuTransitions transitions;
    public TaskEnableDisable taskenabledisabled;
    public GameObject oldCamera;





    public void CompleteTaskIfBothAreConnected()
    {

        if(isBatteryConnected==true && issatacableconnected==true && TaskTracker.currentTaskID==6)
        {

            transitions.PlayMenuAnimation(7);
            TaskTracker.currentTaskID++;
            taskenabledisabled.HideStep7();
            taskenabledisabled.DisplayStep8();
        }


    }


    public void batteryConnected()
    {


        isBatteryConnected = true;
    }

    public void batteryDisconnected()
    {


        isBatteryConnected = false;
    }

    public void satacableConnected()
    {


        issatacableconnected = true;
    }

    public void satacableDisconnected()
    {


        issatacableconnected = false;
    }
}
