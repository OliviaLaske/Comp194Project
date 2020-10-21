using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawCircle1 : MonoBehaviour
{
    public GameObject graphite;
    public GameObject circle;
    // public GameObject player;
    // public GameObject desk;
    public TextMeshPro numbers;
    AudioSource audioSource;
    public AudioClip circleInstructions;
    public AudioClip incorrectCircle;
    public AudioClip pencilPlacementInstructions;
    bool isDrawing = false;
    int counter = 0;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(6.312f);
        circle.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        // player.GetComponent<CountStudents>().enable = false;
        // desk.GetComponent<PlacePencil>().enable = false;
        numbers.text = " ";
        circle.SetActive(false);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = circleInstructions;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 0)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 1;
                }
                isDrawing = false;
            }
        }
        else if(counter == 1)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 2;
                }
                isDrawing = false;
            }
        }
        else if(counter == 2)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 3;
                }
                isDrawing = false;
            }
        }
        else if(counter == 3)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 4;
                }
                isDrawing = false;
            }
        }
        else if(counter == 4)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 5;
                }
                isDrawing = false;
            }
        }
        else if(counter == 5)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                graphite.GetComponent<TrailRenderer>().enabled = true;
                isDrawing = true;
            }
            else
            {
                graphite.GetComponent<TrailRenderer>().Clear();
                graphite.GetComponent<TrailRenderer>().enabled = false;
                if(isDrawing == true)
                {
                    audioSource.clip = incorrectCircle;
                    audioSource.Play(0);
                    counter = 6;
                }
                isDrawing = false;
            }
        }
        else if(counter == 6)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                circle.SetActive(true);
                audioSource.clip = pencilPlacementInstructions;
                audioSource.Play(0);
                StartCoroutine(WaitForSeconds());
                // desk.GetComponent<PlacePencil>().enable = true;
            }
        }
    }
}