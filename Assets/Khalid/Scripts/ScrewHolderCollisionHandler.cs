using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualGrasp;

public class ScrewHolderCollisionHandler : MonoBehaviour
{
    public PlayMenuTransitions menuTransitionScript;
    public TaskEnableDisable taskenablescript;
    private int amountOfScrewsInCup = 0;

    private int amountOfSataScrewsInCup = 0;
    private bool isSataCoverInCup = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("OutsidePhoneScrew") && TaskTracker.currentTaskID==1)
        {
            //Disable all scripts that allow you to interact with this screw
            VG_Articulation[] vg_articulations = other.GetComponents<VG_Articulation>();

            foreach (VG_Articulation vg in vg_articulations)
            {
                vg.enabled = false;
            }

            //Make rigidbody kinematic if it exists
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
                rb.isKinematic = true;


            //PlayAudio
            this.GetComponent<AudioSource>().Play();
            Debug.Log(amountOfScrewsInCup);

            //Check if there are two screws in the cup. If there is then play success sound and go to the next step.

            if (++amountOfScrewsInCup == 4)
                menuTransitionScript.PlayMenuAnimation(1);

            return;

        }


        if (other.gameObject.tag.Equals("SataCoverBolts") && TaskTracker.currentTaskID == 4)
        {
            //Disable all scripts that allow you to interact with this screw
            VG_Articulation[] vg_articulations = other.GetComponents<VG_Articulation>();

            foreach (VG_Articulation vg in vg_articulations)
            {
                vg.enabled = false;
            }

            //Make rigidbody kinematic if it exists
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
                rb.isKinematic = true;


            //PlayAudio
            this.GetComponent<AudioSource>().Play();
            Debug.Log(amountOfSataScrewsInCup);

            //Check if there are two screws in the cup. If there is then play success sound and go to the next step.

            if (++amountOfSataScrewsInCup == 4 && isSataCoverInCup == true)
            {
                menuTransitionScript.PlayMenuAnimation(5);
                taskenablescript.DisplayStep6();
                TaskTracker.currentTaskID++;
            }

            return;

        }


        if (other.gameObject.tag.Equals("SataCover") && TaskTracker.currentTaskID == 4)
        {
            isSataCoverInCup = true;
            //Disable all scripts that allow you to interact with this screw
            VG_Articulation[] vg_articulations = other.GetComponents<VG_Articulation>();

            foreach (VG_Articulation vg in vg_articulations)
            {
                vg.enabled = false;
            }

            //Make rigidbody kinematic if it exists
            Rigidbody rb = other.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
                rb.isKinematic = true;


            //PlayAudio
            this.GetComponent<AudioSource>().Play();

            //Check if there are two screws in the cup. If there is then play success sound and go to the next step.

            if (amountOfSataScrewsInCup == 4 && isSataCoverInCup == true)
            {
                menuTransitionScript.PlayMenuAnimation(5);
                taskenablescript.DisplayStep6();
                TaskTracker.currentTaskID++;
            }


            return;

        }
    }
}
