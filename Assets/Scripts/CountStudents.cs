using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountStudents : MonoBehaviour
{
    public TextMeshPro numbers;
    AudioSource audioSource;
    public AudioClip countingStudentsInstructions;
    public AudioClip countingStudents;
    int counter = 0;
    // public GameObject desk;

    // Start is called before the first frame update
    void Start()
    {
        // desk.GetComponent<Task2>().enable = false;
        audioSource = GetComponent<AudioSource>();
        // numbers.SetActive(true);
        audioSource.clip = countingStudentsInstructions;
        audioSource.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 0 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "1";
            counter = 1;
        }
        else if(counter == 1 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "2";
            counter = 2;
        }
        else if(counter == 2 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "3";
            counter = 3;
        }
        else if(counter == 3 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "4";
            counter = 4;
        }
        else if(counter == 4 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "5";
            counter = 5;
        }
        else if(counter == 5 && OVRInput.GetDown(OVRInput.Button.One))
        {
            numbers.text = "6";
            counter = 0;
            audioSource.clip = countingStudents;
            audioSource.Play(0);
        }
    }
}
