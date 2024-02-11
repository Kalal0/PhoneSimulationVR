using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;
using VirtualGrasp.Scripts;

public class isNewCameraConnected : MonoBehaviour
{
    public bool isNewCameraConnectedbool = false;
    public bool isBottomRightScrewConnected = true;
    public bool isTopLeftScrewConnected = true;

    public PlayMenuTransitions transitions;
    public TaskEnableDisable taskenabledisabled;

    public VG_Assemble oldCameraAssemble;
    public VG_Articulation oldCameraArticulation;

    public void CompleteTaskIfBothAreConnected()
    {

        if (isNewCameraConnectedbool == true && isBottomRightScrewConnected == true && isTopLeftScrewConnected == true && TaskTracker.currentTaskID==7)
        {

            transitions.PlayMenuAnimation(8);
            TaskTracker.currentTaskID++;
            //taskenabledisabled.HideStep8();
        }


    }

    public void MakeOldCamerActiveIfBothDisconnected()
    {

        if (isBottomRightScrewConnected == false && isTopLeftScrewConnected == false && TaskTracker.currentTaskID == 7)
        {

            oldCameraAssemble.enabled = true;
            oldCameraArticulation.enabled = true;
            oldCameraArticulation.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        }


    }

    public void CameraConnected()
    {


        isNewCameraConnectedbool = true;
    }

    public void CameraDisonnected()
    {


        isNewCameraConnectedbool = false;
    }

    public void BottomRightScrewConnected()
    {


        isBottomRightScrewConnected = true;
    }

    public void BottomRightScrewDisconnected()
    {


        isBottomRightScrewConnected = false;
    }

    public void TopLeftScrewConnected()
    {


        isTopLeftScrewConnected = true;
    }

    public void TopLeftScrewDisconnected()
    {


        isTopLeftScrewConnected = false;
    }

}


