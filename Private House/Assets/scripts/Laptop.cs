using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Laptop : MonoBehaviour
{
    public GameObject Mouse;
    public GameObject Movement;
    public GameObject LaptopUI;
    public GameObject Hud;

    public GameObject Login;
    public GameObject User;
    public GameObject Password;

    public GameObject Home;
    public GameObject Pic1;
    public GameObject Pic2;
    public GameObject Pic3;
    public GameObject Note1;
    public GameObject Note2;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject CloseButton;  

    public AudioSource Player1Audio;
    public AudioSource Player2Audio;

    public UnityEvent Event;
    // Start is called before the first frame update
    void Start()
    {
        LaptopUI.SetActive(false); 
        Home.SetActive(false);
        Pic1.SetActive(false);
        Pic2.SetActive(false);
        Pic3.SetActive(false);
        Note1.SetActive(false);
        Note2.SetActive(false);
        Player1.SetActive(false);
        Player2.SetActive(false);
        CloseButton.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (LaptopUI.activeInHierarchy)
        {
            Hud.SetActive(false);
            Mouse.GetComponent<MouseLook>().enabled = false;
            Movement.GetComponent<PlayerMovement>().enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void ShowPic1()
    {
        Pic1.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void ShowPic2()
    {
        Pic2.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void ShowPic3()
    {
        Pic3.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void ShowNote1()
    {
        Note1.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void ShowNote2()
    {
        Note2.SetActive(true);
        CloseButton.SetActive(true);
    }

    public void ShowPlayer1()
    {
        Player1.SetActive(true);
        Player1Audio.Play();
        CloseButton.SetActive(true);
    }

    public void ShowPlayer2()
    {
        Player2.SetActive(true);
        Player2Audio.Play();
        CloseButton.SetActive(true);
    }

    public void CloseApp()
    {
        Pic1.SetActive(false);
        Pic2.SetActive(false);
        Pic3.SetActive(false);
        Note1.SetActive(false);
        Note2.SetActive(false);
        Player1.SetActive(false);
        Player2.SetActive(false);
        Player1Audio.Stop();
        Player2Audio.Stop();
        CloseButton.SetActive(false);
    }

    public void Enter()
    {
        if(User.GetComponent<InputField>().text.ToUpper().Equals("avi sherbot".ToUpper()) && Password.GetComponent<InputField>().text.ToUpper().Equals("Emperor's children".ToUpper()))
        {
            Login.SetActive(false);
            Home.SetActive(true);
            Event.Invoke();
        }
        else 
        {
            User.GetComponent<InputField>().text = "";
            Password.GetComponent<InputField>().text = "";
        }
    }

    public void Exit()
    {
        LaptopUI.SetActive(false);
        Hud.SetActive(true);
        Mouse.GetComponent<MouseLook>().enabled = true;
        Movement.GetComponent<PlayerMovement>().enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
