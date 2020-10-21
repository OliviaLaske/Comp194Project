using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlacePencil : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip correctPencilPlacement;
    public AudioClip countingStudentsInstructions;
    public AudioClip countingStudents;
    // public GameObject player; 
    public GameObject pencil;
    bool isPencilPlaced;
    public TextMeshPro numbers;
    // public GameObject desk;
    int counter = 0;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(6.0f);
    }

    void OnTriggerEnter (Collider other) 
    { 
        if (other.gameObject.name == "Pencil")
        {
            float angle = Vector3.Angle(other.transform.forward, transform.forward);
            Debug.Log("Pencil Placed"); 
            if (angle < 10)
            {
                // pencil.DetachFromParent
                audioSource.clip = correctPencilPlacement;
                audioSource.Play(0); 
                // StartCoroutine(WaitForSeconds());
                // player.GetComponent<CountStudents>().enable = true;
                // desk.GetComponent<PlacePencil>().enable = false;
                // audioSource = GetComponent<AudioSource>();
                numbers.text = "0";
                audioSource.clip = countingStudentsInstructions;
                audioSource.Play(0);
                isPencilPlaced = true;
            }
            else
            {
                isPencilPlaced = false;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // pencil.GetComponent<DrawCircle>().enable = false;
        audioSource = GetComponent<AudioSource>();
    }
    //public Transform target;
    void Update()
    {
        if(isPencilPlaced == true && OVRInput.GetDown(OVRInput.Button.One))
        {
            if(counter < 5)
            {
                counter++;
                numbers.text = "" + counter;
            }
            else if(counter == 5)
            {
                numbers.text = "6";
                counter = 0;
                audioSource.clip = countingStudents;
                audioSource.Play(0);
            }
        }
    }
}