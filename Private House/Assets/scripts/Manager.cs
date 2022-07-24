using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Manager : MonoBehaviour
{
    bool ApartmentKey = false;
    public UnityEvent OpenAparmentDoor;
    public UnityEvent AparmentDoorText;

    bool Fuse = false;
    public UnityEvent InsertFuse;
    public UnityEvent PowerClosetText;

    bool MatchStick = false;
    public UnityEvent LightCandle;
    public UnityEvent LightCandleText;

    bool Candle = false;
    public UnityEvent PlaceCandle;
    public UnityEvent PlaceCandleText;



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

    public void GotCandle()
    {
        Candle = true;
    }

    public void HasCandle()
    {
        if(Candle)
        {
            PlaceCandle.Invoke();
        }
        else
        {
            PlaceCandleText.Invoke();
        }
    }
}
