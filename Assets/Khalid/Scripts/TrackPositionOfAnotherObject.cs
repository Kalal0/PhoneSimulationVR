using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPositionOfAnotherObject : MonoBehaviour
{
    public GameObject objecttotrack;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objecttotrack.transform.position;
        transform.rotation = objecttotrack.transform.rotation;
    }
}
