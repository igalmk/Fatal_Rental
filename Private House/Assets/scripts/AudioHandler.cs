using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    public AudioSource audioSource;
    private bool AlreadyPlayed=false;
    public void playAudioOnce()
    {
        if (!AlreadyPlayed)
        {
            audioSource.Play();
            AlreadyPlayed = true;
        }
    }
}
