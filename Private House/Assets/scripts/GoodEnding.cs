using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoodEnding : MonoBehaviour
{
    public float Transitiontime = 2f;
    public Animator Transition;

    public void EndGameSequence()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Transition.SetTrigger("Start");
        yield return new WaitForSeconds(Transitiontime);
        SceneManager.LoadScene(levelIndex);
    }
}
