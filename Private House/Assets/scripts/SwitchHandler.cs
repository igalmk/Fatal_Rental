using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchHandler : MonoBehaviour
{
    public UnityEvent LightOn;
    public UnityEvent LightOff;
    public bool LightToggle=false;

    public void SwitchLight() 
    {
        if(!LightToggle)
        {
            LightOn.Invoke();
            LightToggle = true;
        }
        else
        {
            LightOff.Invoke();
            LightToggle=false;
        }
    }

}
