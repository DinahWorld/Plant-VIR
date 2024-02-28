using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ARButtonManager : MonoBehaviour
{
    public AnimationController animationController;
    private bool sun = false;
    private bool water = false;

    public void OnSunButtonClick()
    {
        if(water == true) 
        {
            sun = true;
        }
    }

    public void OnWaterButtonClick()
    {
        water = true;
        if (animationController != null)
        {
            animationController.SetWaterTrue();
        }
    }

    private void Update()
    {
        if (sun)
        {
            if (animationController != null)
            {
                animationController.setSunTrue();
                sun = false;
                water = false;
            }
        }
        
        
    }

}
