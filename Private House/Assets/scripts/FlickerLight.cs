using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLight : MonoBehaviour
{
    public bool IsFlickering = false;
    public float TimeDelay;

    // Update is called once per frame
    void Update()
    {
        if(!IsFlickering)
        {
            StartCoroutine(FlickeringLight());
        }
    }

    IEnumerator FlickeringLight()
    {
        IsFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        TimeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(TimeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        TimeDelay = Random.Range(0.01f, 0.2f);
        yield return new WaitForSeconds(TimeDelay);
        IsFlickering = false;
    }
}
