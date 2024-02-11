using System.Collections;
using System.Collections.Generic;
using HPhysic;
using UnityEngine;
using VirtualGrasp;

public class HandleSataConnectionONOFF : MonoBehaviour
{
    public  bool Connector1IsConnected = true;
    public  bool Connector2IsConnected = true;
    public  bool Connector3IsConnected = true;
    public GameObject satacover;
    public GameObject coll;

    public void OnConnection1Connected() { Connector1IsConnected = true; }
    public void OnConnection2Connected() { Connector2IsConnected = true; }
    public void OnConnection3Connected() { Connector3IsConnected = true; }

    public void OnConnection1Disconnected() { Connector1IsConnected = false; }
    public void OnConnection2Disconnected() { Connector2IsConnected = false; }
    public void OnConnection3Disconnected() { Connector3IsConnected = false; }


    public void OnAllConnectionConnected() 
    { 
    
        if (Connector1IsConnected==true && Connector2IsConnected == true && Connector3IsConnected == true)
        {

            satacover.GetComponent<Rigidbody>().isKinematic = true;
            satacover.GetComponent<VG_Articulation>().enabled = true;
            coll.SetActive(true);


        }
    
    }

}