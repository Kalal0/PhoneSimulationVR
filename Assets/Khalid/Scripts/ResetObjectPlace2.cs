using System.Collections.Generic;
using UnityEngine;

public class ResetObjectPlace2 : MonoBehaviour
{
    // List of game objects whose transforms will be saved
    public List<GameObject> gameObjectsList;

    // Dictionary to store original transforms of game objects
    private Dictionary<GameObject, Transform> originalTransforms = new Dictionary<GameObject, Transform>();

    // Y threshold below which objects will be teleported back
    public float yThreshold = -10f;

    void Start()
    {
        // Save original transforms of game objects
        foreach (GameObject obj in gameObjectsList)
        {
            if (obj != null)
            {
                originalTransforms[obj] = obj.transform;
            }
        }
    }

    void Update()
    {
        // Check Y position of game objects and teleport them back if necessary
        foreach (KeyValuePair<GameObject, Transform> kvp in originalTransforms)
        {
            GameObject obj = kvp.Key;
            Transform originalTransform = kvp.Value;

            if (obj != null && obj.transform.position.y < yThreshold)
            {
                TeleportObjectBack(obj, originalTransform);
            }
        }
    }

    // Function to teleport object back to its original position
    private void TeleportObjectBack(GameObject obj, Transform originalTransform)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();

        // Set Rigidbody to kinematic
        if (rb != null)
        {
            rb.isKinematic = true;
        }

        // Teleport object back to original position
        obj.transform.position = originalTransform.position;
        obj.transform.rotation = originalTransform.rotation;

        // Set Rigidbody back to its initial state
        if (rb != null)
        {
            rb.isKinematic = false;
        }
    }
}
