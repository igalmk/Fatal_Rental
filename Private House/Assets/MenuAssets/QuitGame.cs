using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
   public void Quitgame()
    {
        Application.Quit();
    }

    void OnLevelWasLoaded(int level)
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }
}
