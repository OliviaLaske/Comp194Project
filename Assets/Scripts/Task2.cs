using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    AudioSource audioSource;
    public GameObject player; 

    void OnTriggerEnter (Collider other) 
    { 
        if (other.gameObject.name == "Pencil")
        {
            float angle = Vector3.Angle(other.transform.forward, transform.forward);
            Debug.Log("Pencil Placed"); 
            if (angle < 10)
            {
                // audioSource.clip = pencilPlacement;
                audioSource.Play(0); 
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = player.GetComponent<AudioSource>();
    }
    //public Transform target;
    void Update()
    {

    }
  
}
