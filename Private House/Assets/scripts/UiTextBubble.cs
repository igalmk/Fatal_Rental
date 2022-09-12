using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiTextBubble : MonoBehaviour
{
    public GameObject TextBubble;
    public Text Text;
    private float Duration;
    private bool CanShowText;
    private bool DisplayText;
    // Start is called before the first frame update
    void Start()
    {
        TextBubble.SetActive(false);
        DisplayText = false;
        CanShowText = true;
    }

    void Update()
    {

        if (DisplayText)
        {
            Duration -= Time.deltaTime;
        }
        if (Duration <= 0)
        {
            DisplayText = false;
            CanShowText = true;
            TextBubble.SetActive(false);
        }
    }
    public void ShowTextBubble(string i_Text)
    {
        if (CanShowText)
        {
            CanShowText = false;
            TextBubble.SetActive(true);
            Text.text = i_Text;
            Duration = 3f;
            DisplayText = true;
        }
    }

}
