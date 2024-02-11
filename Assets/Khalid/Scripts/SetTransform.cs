using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTransform : MonoBehaviour
{
    public Transform ObjectTransform;
    private Vector3 position;
    private Quaternion rotation;
    private Vector3 scale;



    public void Start()
    {
        position = ObjectTransform.transform.localPosition;
        rotation = ObjectTransform.transform.localRotation;
        scale = ObjectTransform.transform.localScale;

    }
    public void setNewTransform ()
    {

        this.transform.localPosition = position;
        this.transform.localRotation = rotation; 
        this.transform.localScale = scale;
    }
}
