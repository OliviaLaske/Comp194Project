using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpPencilPlacement : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip tooUp;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Pencil")
        {
            audioSource.clip = tooUp;
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
