using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRigidBodyOnDissassemble : MonoBehaviour
{
    public SpringJoint point0Joint;



    public void UpdateRigidBody()
    {


        this.TryGetComponent<Rigidbody>(out Rigidbody rb);

        if(rb != null)
        {

            point0Joint.connectedBody = rb;

        }
    }
}
