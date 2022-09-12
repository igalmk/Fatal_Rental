using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Animator Transition;
    public float Transitiontime = 1f;
    public float VideoPlaytime = 1f;
    public AudioSource AudioSource;

    public GameObject Movement;

    public void EndGameSequence()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        Movement.GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(VideoPlaytime);
        Transition.SetTrigger("Start");
        yield return new WaitForSeconds(Transitiontime);
        AudioSource.Play();
        yield return new WaitForSeconds(Transitiontime);
        SceneManager.LoadScene(levelIndex);
    }
}
