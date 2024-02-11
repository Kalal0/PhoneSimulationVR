using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;
using VirtualGrasp.Scripts;

public class ConnectionCoverFinalStepCollision : MonoBehaviour
{
    public SetTransform Settransformscript;

    public VG_Assemble screw1Assemble;
    public VG_Articulation screw1Articulation;

    public VG_Assemble screw2Assemble;
    public VG_Articulation screw2Articulation;

    public GameObject finalcollider;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("ConnectionConverFinalStep"))
        {

            this.GetComponent<Rigidbody>().isKinematic=true;
            this.GetComponent<VG_Articulation>().enabled=false;
            finalcollider.SetActive(true);
            Settransformscript.setNewTransform();

            screw1Assemble.enabled=true;
            screw1Assemble.gameObject.GetComponent<Rigidbody>().isKinematic=false;
            screw1Articulation.enabled = true;
            screw2Assemble.enabled = true;
            screw2Assemble.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            screw2Articulation.enabled = true;
        }
    }
}
