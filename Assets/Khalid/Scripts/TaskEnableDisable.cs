using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using VirtualGrasp;
using VirtualGrasp.Scripts;

public class TaskEnableDisable : MonoBehaviour
{
    //Task 5
    public VG_Assemble RightScrewAssemble;
    public VG_Assemble LeftScrewAssemble;

    public VG_Articulation RightScrewArticulation;
    public VG_Articulation LeftScrewArticulation;

    //Task 6
    public GameObject GreenLed;

    public VG_Assemble Connector1Assemble;
    public VG_Assemble Connector2Assemble;
    public VG_Assemble Connector3Assemble;

    public VG_Articulation Connector1Articulation;
    public VG_Articulation Connector2Articulation;
    public VG_Articulation Connector3Articulation;

    //Task 7
    public VG_Assemble CableAsse;
    public VG_Assemble BatteryAsse;

    public VG_Articulation CableArt;
    public VG_Articulation BatteryArt;


    //Task 8
    public VG_Assemble ScrewRightAssemble;
    public VG_Assemble ScrewLeftAssemble;

    public VG_Articulation ScrewRightArti;
    public VG_Articulation ScrewLeftArti;


    //Task 9
    public VG_Assemble Connector1AssembleNEW;
    public VG_Assemble Connector2AssembleNEW;
    public VG_Assemble Connector3AssembleNEW;

    public VG_Articulation Connector1ArticulationNEW;
    public VG_Articulation Connector2ArticulationNEW;
    public VG_Articulation Connector3ArticulationNEW;

    public GameObject NewScreen;

    //Task 10
    public VG_Assemble FirstScrewAssemble;
    public VG_Assemble SecondScrewAssemble;

    public VG_Articulation FirstScrewArticulation;
    public VG_Articulation SecondScrewArticulation;

    public GameObject FirstScrew;
    public GameObject SecondScrew;


    public void DisplayStep5()
    {

        RightScrewAssemble.enabled = true;
        LeftScrewAssemble.enabled = true;

        RightScrewArticulation.enabled = true;
        LeftScrewArticulation.enabled = true;

    }


    public void DisplayStep6()
    {

        GreenLed.SetActive(true);

        Connector1Assemble.enabled = true;
        Connector2Assemble.enabled = true;
        Connector3Assemble.enabled = true;

        Connector1Articulation.enabled = true;
        Connector2Articulation.enabled = true;
        Connector3Articulation.enabled = true;

    }


    public void DisplayStep7()
    {

        CableAsse.enabled = true;
        BatteryAsse.enabled = true;

        CableArt.enabled = true;
        BatteryArt.enabled = true;


    }

    public void HideStep7()
    {
        CableAsse.enabled = false;
        BatteryAsse.enabled = false;

        CableArt.enabled = false;
        BatteryArt.enabled = false;

    }



    public void DisplayStep8()
    {

        ScrewRightAssemble.enabled = true;
        ScrewLeftAssemble.enabled = true;

        ScrewRightArti.enabled = true;
        ScrewLeftArti.enabled = true;


    }

    public void HideStep8()
    {
        ScrewRightAssemble.enabled = false;
        ScrewLeftAssemble.enabled = false;

        ScrewRightArti.enabled = false;
        ScrewLeftArti.enabled = false;

    }


    /*
    public void DisplayStep9()
    {

        NewScreen.GetComponent<Rigidbody>().isKinematic = false;
        NewScreen.GetComponent<XRGrabInteractable>().enabled = true;

        Connector1AssembleNEW.enabled = true;
        Connector2AssembleNEW.enabled = true;
        Connector3AssembleNEW.enabled = true;

        Connector1ArticulationNEW.enabled = true;
        Connector2ArticulationNEW.enabled = true;
        Connector3ArticulationNEW.enabled = true;


    }

    public void HideStep9()
    {
        NewScreen.GetComponent<Rigidbody>().isKinematic = true;
        NewScreen.GetComponent<XRGrabInteractable>().enabled = false;

        Connector1AssembleNEW.enabled = false;
        Connector2AssembleNEW.enabled = false;
        Connector3AssembleNEW.enabled = false;

        Connector1ArticulationNEW.enabled = false;
        Connector2ArticulationNEW.enabled = false;
        Connector3ArticulationNEW.enabled = false;

    }
    */


    public void DisplayStep10()
    {
        FirstScrew.GetComponent<Rigidbody>().isKinematic = false;
        SecondScrew.GetComponent<Rigidbody>().isKinematic = false;

        FirstScrewAssemble.enabled = true;
        SecondScrewAssemble.enabled = true;


        FirstScrewArticulation.enabled = true;
        SecondScrewArticulation.enabled = true;


}
}
