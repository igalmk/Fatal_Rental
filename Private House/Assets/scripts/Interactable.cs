using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent OnInteract;
    public int ID;

    private void Start()
    {
        ID = Random.Range(0,99999);
        
    }
}
