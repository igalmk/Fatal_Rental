using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ExitMessage : MonoBehaviour
{
    public GameObject Mouse;
    public GameObject Movement;
    public GameObject ExitMessageUI;
    public GameObject Hud;

    public UnityEvent Event;

    void Start()
    {
        ExitMessageUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        if (ExitMessageUI.activeInHierarchy)
        {
            Hud.SetActive(false);
            Mouse.GetComponent<MouseLook>().enabled = false;
            Movement.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void ExitButton()
    {
        Event.Invoke();
    }

    public void ReturnButton()
    {
        ExitMessageUI.SetActive(false);
        Hud.SetActive(true);
        Mouse.GetComponent<MouseLook>().enabled = true;
        Movement.GetComponent<PlayerMovement>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
