using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PhoneUI : MonoBehaviour
{

    public GameObject Mouse;
    public GameObject Movement;
    public GameObject PhonePadUI;
    public GameObject Hud;

    public Text Text;
    public string Answer = "06395";

    public AudioSource button;
    public AudioSource right;
    public AudioSource wrong;

    public UnityEvent Event;

    private bool IsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        PhonePadUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOpen)
        {
            Event.Invoke();
            IsOpen = false;
        }

        if (PhonePadUI.activeInHierarchy)
        {
            Hud.SetActive(false);
            Mouse.GetComponent<MouseLook>().enabled = false;
            Movement.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Number(int number)
    {
        Text.text += number.ToString();
        button.Play();
    }

    public void Enter()
    {
        if (Text.text.Equals(Answer))
        {
            Text.text = "*****";
            IsOpen = true;
        }
        else
        {
            wrong.Play();
            Text.text = "Calling "+Text.text;
        }
    }

    public void Clear()
    {
        Text.text = "";
        button.Play();
        wrong.Stop();
    }

    public void Exit()
    {
        button.Play();
        Text.text="";
        PhonePadUI.SetActive(false);
        Hud.SetActive(true);
        Mouse.GetComponent<MouseLook>().enabled = true;
        Movement.GetComponent<PlayerMovement>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
