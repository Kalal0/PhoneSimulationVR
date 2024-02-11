using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;
using VirtualGrasp.Scripts;

public class ChangeScrewAssemblyType : MonoBehaviour
{
    public VG_Assemble vg_assemblescript;


    public void ChangeAssemblyMode(VG_Articulation vg)
    {
        Debug.Log("I have changed the mode of assembly");
        vg_assemblescript.m_assembleArticulation = vg;
        vg_assemblescript.thisIsOnlyTrueOnTheFirstRun = false;

    }

    public void ChangeAssemblyMode2(VG_Articulation vg)
    {
        Debug.Log("I have changed the mode of assembly");
        vg_assemblescript.m_assembleArticulation = vg;
        vg_assemblescript.thisIsOnlyTrueOnTheFirstRun2 = false;

    }

}
