using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlowdryerAirDetection1 : MonoBehaviour
{
    public float timeRemaining = 10f;
    private bool timerIsRunning = false;
    public TMP_Text timeText; 
    public PlayMenuTransitions transitions;

    private void Update()
    {
        if (timerIsRunning && TaskTracker.currentTaskID==1 && HairBlowerOnOff.ison)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                DisplayTime(timeRemaining);
                TaskTracker.currentTaskID = 2;
                transitions.PlayMenuAnimation(2);
            }
        }
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}", seconds);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Blowdryer_AirCollider"))
            timerIsRunning = true;

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag.Equals("Blowdryer_AirCollider"))
            timerIsRunning = false;
    }
}