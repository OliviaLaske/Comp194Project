using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip correctPencilPlacement;
    public GameObject player; 
    // public GameObject pencil;

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
                audioSource.clip = correctPencilPlacement;
                audioSource.Play(0); 
                StartCoroutine(WaitForSeconds());
                // player.GetComponent<CountStudents>().enable = true;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        // pencil.GetComponent<DrawCircle>().enable = false;
        audioSource = player.GetComponent<AudioSource>();
    }
    //public Transform target;
    void Update()
    {

    }
  
}
