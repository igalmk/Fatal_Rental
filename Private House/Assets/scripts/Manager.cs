using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Manager : MonoBehaviour
{
    private bool ApartmentKey = false;
    public UnityEvent OpenAparmentDoor;
    public UnityEvent AparmentDoorText;

    private bool Fuse = false;
    public UnityEvent InsertFuse;
    public UnityEvent PowerClosetText;

    private bool MatchStick = false;
    public UnityEvent LightCandle;
    public UnityEvent LightCandleText;

    private bool Power = false;
    public UnityEvent TurnLightOn;
    public UnityEvent SwitchText;

    private bool Disc = false;
    public UnityEvent PlayDVD;
    public UnityEvent DVDText;

    private bool DVDIsOn = false;
    public UnityEvent PlayTV;
    public UnityEvent TVText;

    public UnityEvent CorrectPhonePassword;

    public void GotApartmentKey()
    {
        ApartmentKey = true;
    }
    public void HasApartmentKey()
    {
        if (ApartmentKey)
        {
            OpenAparmentDoor.Invoke();
        }
        else
        {
            AparmentDoorText.Invoke();
        }
    }

    public void GotFuse()
    {
        Fuse = true;
    }
    public void HasFuse()
    {
        if(Fuse)
        {
            InsertFuse.Invoke();
            GotPower();
        }
        else
        {
            PowerClosetText.Invoke();
        }
    }

    public void GotMatchStick()
    {
        MatchStick = true;
    }
    public void HasMatchStick()
    {
        if(MatchStick)
        {
            LightCandle.Invoke();
        }
        else
        {
            LightCandleText.Invoke();
        }
    }

    public void GotPower()
    {
        Power = true;
    }
    public void HasPower()
    {
        if (Power)
        {
            TurnLightOn.Invoke();
        }
        else
        {
            SwitchText.Invoke();
        }
    }

    public void GotDisc()
    {
        Disc = true;
    }
    public void HasDisc()
    {
        if(Disc)
        {
            PlayDVD.Invoke();
            GotDVDIsOn();
        }
        else
        {
            DVDText.Invoke();
        }
    }

    public void GotDVDIsOn()
    {
        DVDIsOn = true;
    }
    public void HasDVDIsOn()
    {
        if(DVDIsOn)
        {
            PlayTV.Invoke();
        }
        else
        {
            TVText.Invoke();
        }
    }


    public void GotCorrectPhonePassword()
    {
        CorrectPhonePassword.Invoke();
    }


}
