using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitDistanceBetweenTwoGameobjects : MonoBehaviour
{
    public Transform referencePoint; // The other point to measure the distance from
    public float maxDistance; // Maximum allowed distance

    public Transform OtherReferencePoint;

    void Start()
    {

    }

    void Update()
    {
        // Calculate current distance
        float currentDistance = Vector3.Distance(OtherReferencePoint.position, referencePoint.position);
        Debug.Log(currentDistance);

        // Constrain movement
        if (currentDistance > maxDistance)
        {
            Vector3 direction = (OtherReferencePoint.position - referencePoint.position).normalized;
            transform.position = OtherReferencePoint.position + direction* maxDistance;
        }
    }
}