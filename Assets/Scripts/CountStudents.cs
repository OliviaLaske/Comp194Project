using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountStudents : MonoBehaviour
{
    public TextMeshPro Numbers;
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

    }

    // Update is called once per frame
    void Update()
    {
        if(Counter == 0 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "1";
            Counter = 1;
        }
        else if(Counter == 1 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "2";
            Counter = 2;
        }
        else if(Counter == 2 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "3";
            Counter = 3;
        }
        else if(Counter == 3 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "4";
            Counter = 4;
        }
        else if(Counter == 4 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "5";
            Counter = 5;
        }
        else if(Counter == 5 && OVRInput.Get(OVRInput.Button.One))
        {
            Numbers.text = "6";
            Counter = 0;
        }

        /*
        if(Counter == 0 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "1";
            Counter = 1;
        }
        else if(Counter == 1 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "2";
            Counter = 2;
        }
        else if(Counter == 2 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "3";
            Counter = 3;
        }
        else if(Counter == 3 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "4";
            Counter = 4;
        }
        else if(Counter == 4 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "5";
            Counter = 5;
        }
        else if(Counter == 5 && Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Numbers.text = "6";
            Counter = 0;
        }
        */

        /*
        if(Counter == 0)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                Numbers.text = "1";
                Counter = 1;
            }
        }
        else if(Counter == 1)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                Numbers.text = "2";
                Counter = 2;
            }
        }
        */

        /*
        for(int i = 0; i < 17; i++)
        {
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 0)
                {
                    Numbers.text = "1";
                    Counter = 1;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 1)
                {
                    Numbers.text = "2";
                    Counter = 2;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 2)
                {
                    Numbers.text = "3";
                    Counter = 3;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 3)
                {
                    Numbers.text = "4";
                    Counter = 4;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 4)
                {
                    Numbers.text = "5";
                    Counter = 5;
                }
            }
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 5)
                {
                    Numbers.text = "6";
                    Counter = 6;
                    // play audio
                    StartCoroutine(WaitForSeconds());
                    Numbers.text = "0";
                }
            }
        }
        */
    }
}
