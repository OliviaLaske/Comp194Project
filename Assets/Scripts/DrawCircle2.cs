using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle2 : MonoBehaviour
{
    public GameObject graphite;
    public GameObject circle;
    AudioSource audioSource;
    public AudioClip incorrectCircle;
    public AudioClip pencilPlacementInstructions;
    bool isDrawing = false;
    bool isCirclePerfect = false;
    int counter = 0;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(3.0f);
    }

    IEnumerator WaitForSeconds1()
    {
        yield return new WaitForSeconds(6.312f);
    }

    void DrawCircle()
    {
        // for(int i = 0; i < 2; i++)
        while(isCirclePerfect == false)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                StartCoroutine(WaitForSeconds());
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = counter + 1;
                }
                isDrawing = false;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        circle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        for(int i = 0; i < 10; i++)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                StartCoroutine(WaitForSeconds());
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                }
                isDrawing = false;
            }
        }
        */

        // Calls method to complete the task.
        DrawCircle();

        // When the task is to be completed.
        if(counter == 2)
        {
            isCirclePerfect = true;
        }

        if(isCirclePerfect == true)
        {
            circle.SetActive(true);
            audioSource.clip = pencilPlacementInstructions;
            audioSource.Play(0);
            StartCoroutine(WaitForSeconds1());
            circle.SetActive(false);
        }
    }
}
