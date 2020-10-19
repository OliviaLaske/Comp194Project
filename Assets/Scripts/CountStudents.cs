using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountStudents : MonoBehaviour
{
    public TextMeshPro Numbers;
    AudioSource audioSource;
    public AudioClip countingStudentsInstructions;
    public AudioClip countingStudents;
    int Counter = 0;

    /*
    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(5.0f);
    }
    */

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = countingStudentsInstructions;
        audioSource.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Counter == 0 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "1";
            Counter = 1;
        }
        else if(Counter == 1 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "2";
            Counter = 2;
        }
        else if(Counter == 2 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "3";
            Counter = 3;
        }
        else if(Counter == 3 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "4";
            Counter = 4;
        }
        else if(Counter == 4 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "5";
            Counter = 5;
        }
        else if(Counter == 5 && OVRInput.GetDown(OVRInput.Button.One))
        {
            Numbers.text = "6";
            Counter = 0;
            audioSource.clip = countingStudents;
            audioSource.Play(0);
        }
    }
}
