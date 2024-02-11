using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidBodyToObject : MonoBehaviour
{
    Rigidbody body;
public void AddRigidBody()
    {


        body = transform.gameObject.AddComponent<Rigidbody>();

    }


    public void RemoveRigidBody()
    {

        if(body != null)
        Destroy(body);
    }
}
