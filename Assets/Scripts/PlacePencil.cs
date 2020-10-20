using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacePencil : MonoBehaviour
{
    public GameObject desk;
    AudioSource audioSource;
    public AudioClip correctPencilPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = correctPencilPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 2.86f && transform.position.x < 3.018f)
        {
            if(transform.position.z < -1.34f && transform.position.z > -1.6f)
            {
                if(Vector3.Angle(transform.forward, desk.transform.forward) < 10)
                {
                    audioSource.Play(0);
                }
            }
        }
    }
}
