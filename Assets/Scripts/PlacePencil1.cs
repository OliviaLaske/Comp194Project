using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlacePencil1 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip incorrectPencilPlacement;
    public AudioClip correctPencilPlacement;
    public AudioClip countingStudentsInstructions;
    public AudioClip countingStudents;
    public AudioClip countingStudentsEnd;
    public GameObject pencil;
    bool isPencilPlaced = false;
    public TextMeshPro numbers;
    public TextMeshPro instructions;
    public GameObject desk;
    int counter = 0;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(6.0f);
        audioSource = GetComponent<AudioSource>();
        instructions.text = "Press A to count students";
        numbers.text = "0";
        audioSource.clip = countingStudentsInstructions;
        audioSource.Play(0);
        isPencilPlaced = true;
    }

    void OnTriggerEnter (Collider other) 
    { 
        if(other.gameObject.name == "Pencil")
        {
            float angle = Vector3.Angle(other.transform.forward, Vector3.back);
            Debug.Log("Pencil Placed"); 
            if (angle < 10)
            {
                // pencil.transform.parent = desk.transform;
                Destroy(pencil);
                audioSource.clip = correctPencilPlacement;
                audioSource.Play(0); 
                StartCoroutine(WaitForSeconds());
                // player.GetComponent<CountStudents>().enable = true;
                // desk.GetComponent<PlacePencil>().enable = false;
            }
            else
            {
                audioSource.clip = incorrectPencilPlacement;
                audioSource.Play(0);
                isPencilPlaced = false;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if(isPencilPlaced == true)
        {
            if(counter == 0 && OVRInput.GetDown(OVRInput.Button.One))
            {
                numbers.text = "1";
                counter = 1;
                instructions.text = " ";
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
                counter = 6;
                audioSource.clip = countingStudents;
                audioSource.Play(0);
            }
            else if(counter == 6 && OVRInput.GetDown(OVRInput.ButtonOne))
            {
                instructions.text = "Task completed";
                audioSource.clip = countingStudentsEnd;
                audioSource.Play(0);
            }
        }
    }
}