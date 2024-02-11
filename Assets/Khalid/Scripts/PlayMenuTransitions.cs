using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuTransitions : MonoBehaviour
{

    public GameObject lightSphere;
    public Material whiteColor;
    public Material greenColorLED;


    public UIAutoAnimation menuAnimationScript0;
    public UIAutoAnimation menuAnimationScript1;
    public UIAutoAnimation menuAnimationScript2;
    public UIAutoAnimation menuAnimationScript3;
    public UIAutoAnimation menuAnimationScript4;
    public UIAutoAnimation menuAnimationScript5;
    public UIAutoAnimation menuAnimationScript6;
    public UIAutoAnimation menuAnimationScript7;
    public UIAutoAnimation menuAnimationScript8;
    public UIAutoAnimation menuAnimationScript9;
    public UIAutoAnimation menuAnimationScript10;
    public UIAutoAnimation menuAnimationScript11;

    private void Start()
    {
        menuAnimationScript1.ExitAnimation();
        menuAnimationScript2.ExitAnimation();
        menuAnimationScript3.ExitAnimation();
        menuAnimationScript4.ExitAnimation();
        menuAnimationScript5.ExitAnimation();
        menuAnimationScript6.ExitAnimation();
        menuAnimationScript7.ExitAnimation();
        menuAnimationScript8.ExitAnimation();
        menuAnimationScript9.ExitAnimation();
        menuAnimationScript10.ExitAnimation();
        menuAnimationScript11.ExitAnimation();
    }


    public void revertColor()
    {

        lightSphere.GetComponent<Renderer>().material = whiteColor;

    }
    public void TaskComplete()
    {

        lightSphere.GetComponent<Renderer>().material = greenColorLED;
        lightSphere.GetComponent<AudioSource>().Play();
        Invoke("revertColor", 5f);

    }

    //Depending on the case exit the fade out the current menu and fade in the menu that comes afterwards.
    public void PlayMenuAnimation(int index)
    {

                IEnumerator WaitThenPlayAnimation(UIAutoAnimation menuAnimationScript, float waitTime)
                {
                    yield return new WaitForSeconds(waitTime);
                    menuAnimationScript.EntranceAnimation();
                }

        switch (index)
        {

            case 0:

                menuAnimationScript0.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript1,2.0F));
                TaskComplete();



                break;

            case 1:

                menuAnimationScript1.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript2, 2.0F));
                TaskComplete();
                break;


            case 2:
                menuAnimationScript2.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript3, 2.0F));
                TaskComplete();
                break;

            case 3:
                menuAnimationScript3.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript4, 2.0F));
                TaskComplete();
                break;

            case 4:
                menuAnimationScript4.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript5, 2.0F));
                TaskComplete();
                break;

            case 5:
                menuAnimationScript5.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript6, 2.0F));
                TaskComplete();
                break;

            case 6:
                menuAnimationScript6.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript7, 2.0F));
                TaskComplete();
                break;

            case 7:
                menuAnimationScript7.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript8, 2.0F));
                TaskComplete();
                break;

            case 8:
                menuAnimationScript8.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript9, 2.0F));
                TaskComplete();
                break;

            case 9:
                menuAnimationScript9.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript10, 2.0F));
                TaskComplete();
                break;

            case 10:
                menuAnimationScript10.ExitAnimation();

                StartCoroutine(WaitThenPlayAnimation(menuAnimationScript11, 2.0F));
                TaskComplete();
                break;

            default: 
                break;
        }

    }





}
