using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;

public class WhenToMakeSataCoverActive : MonoBehaviour
{
    public bool LeftScrewIsConnected=true;
    public bool RightScrewIsConnected=true;


    public void MakeSataCoverActive()
    {

        if(LeftScrewIsConnected==false && RightScrewIsConnected==false)
        {

            this.GetComponent<Rigidbody>().isKinematic = false;
            this.GetComponent<VG_Articulation>().enabled = true;

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
