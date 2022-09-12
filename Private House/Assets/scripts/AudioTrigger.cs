using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AudioTrigger : MonoBehaviour
{
    private bool Trigger = false;
    public AudioSource Sound;
    private bool AlreadyTriggered = false;
    public UnityEvent Event;

    public void OnTriggerEnter(Collider other)
    {
        if (!AlreadyTriggered&& Trigger)
        {
            Sound.Play();
            Event.Invoke();
            AlreadyTriggered = true;
        }
    }

    public void PrepareTrigger()
    {
        Trigger=true;
    }
}
