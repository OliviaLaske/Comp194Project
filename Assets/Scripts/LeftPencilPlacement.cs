using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPencilPlacement : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip tooLeft;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Pencil")
        {
            audioSource.clip = tooLeft;
            audioSource.Play(0); 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
