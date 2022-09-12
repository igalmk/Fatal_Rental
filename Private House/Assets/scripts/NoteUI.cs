using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NoteUI : MonoBehaviour
{
    public GameObject Mouse;
    public GameObject Movement;
    public GameObject Note;
    public GameObject Hud;

    void Start()
    {
        Note.SetActive(false);
    }

    void Update()
    {
        if (Note.activeInHierarchy)
        {
            Hud.SetActive(false);
            Mouse.GetComponent<MouseLook>().enabled = false;
            Movement.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void Exit()
    {
        Note.SetActive(false);
        Hud.SetActive(true);
        Mouse.GetComponent<MouseLook>().enabled = true;
        Movement.GetComponent<PlayerMovement>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
