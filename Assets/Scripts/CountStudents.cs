using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountStudents : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Zero;
    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject Six;
    int Counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        Cube.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 5; i++)
        {
            Zero.SetActive(true);
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            { 
                if(Counter == 0)
                {
                    Zero.SetActive(false);
                    One.SetActive(true);
                    Counter = 1;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 1)
                {
                    One.SetActive(false);
                    Two.SetActive(true);
                    Counter = 2;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 2)
                {
                    Two.SetActive(false);
                    Three.SetActive(true);
                    Counter = 3;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 3)
                {
                    Three.SetActive(false);
                    Four.SetActive(true);
                    Counter = 4;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 4)
                {
                    Four.SetActive(false);
                    Five.SetActive(true);
                    Counter = 5;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 5)
                {
                    Five.SetActive(false);
                    Six.SetActive(true);
                    Counter = 0;
                }
            }
        }

    }
}
