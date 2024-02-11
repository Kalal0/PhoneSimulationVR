using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp.Scripts;

public class OnSuctionCupDissasemble : MonoBehaviour
{
    public PlayMenuTransitions menutransition;
    public GameObject screen;
    public GameObject PickPoints;
    public void OnSuctionCupDissasembleMethod()
    {

        if(TaskTracker.currentTaskID==2) 
        {
            TaskTracker.currentTaskID++;
            menutransition.PlayMenuAnimation(3);
            this.GetComponent<VG_Assemble>().enabled = false;

            //raise screen by a bit
            screen.transform.localPosition = new Vector3(screen.transform.localPosition.x, screen.transform.localPosition.y, screen.transform.localPosition.z + 0.012f);

            //DisplayPickPoints
            PickPoints.SetActive(true);


        }

    }


}
