using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairBlowerOnOff : MonoBehaviour
{
    public static bool ison= false;
    public Material LEDMaterial;
    public Material BlackMaterial;
    public AudioSource airAudio;
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("FingerCollider"))
        {

            if(ison)
            {

                this.GetComponent<Renderer>().material = BlackMaterial;
                airAudio.Stop();
                ison = false;

            }
            else
            {

                this.GetComponent<Renderer>().material = LEDMaterial;
                airAudio.Play();
                ison = true;

            }


        }

    }
}
