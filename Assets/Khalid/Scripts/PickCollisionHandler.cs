using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickCollisionHandler : MonoBehaviour
{
    public static int howManyPlacesHaveBeenPicked=0;
    public AudioSource ticksound;
    public PlayMenuTransitions transitions;
    public GameObject Screen;
    public TMP_Text pointscovered;

    public TaskEnableDisable taskenabledisablescript;
    public void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag.Equals("Picktargets") && TaskTracker.currentTaskID==3)
        {

            other.gameObject.SetActive(false);
            howManyPlacesHaveBeenPicked++;

            if(ticksound.isPlaying)
                ticksound.Stop();

            ticksound.Play();
                pointscovered.text = howManyPlacesHaveBeenPicked.ToString();
            Debug.Log(howManyPlacesHaveBeenPicked);

            if (howManyPlacesHaveBeenPicked==8)
            {
                
                TaskTracker.currentTaskID++;
                transitions.PlayMenuAnimation(4);
                Screen.GetComponent<Rigidbody>().isKinematic = false;
                Screen.GetComponent<XRGrabInteractable>().enabled = true;
                taskenabledisablescript.DisplayStep5();
            }

        }


    }
}
