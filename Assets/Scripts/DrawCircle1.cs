using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle1 : MonoBehaviour
{
    public GameObject graphite;
    Vector3 graphitePoint = new Vector3(-0.75f, 0f, 0.1f);
    Vector3 pencilPosition;
    Vector3 drawPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            pencilPosition = transform.position;
            drawPoint = pencilPosition + graphitePoint;
            Instantiate(graphite, drawPoint, transform.rotation);
        }

        /*
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.transform.tag == "Paper")
                {
                    point = new Vector3(transform.position.x, transform.position.y, transform.position.z) - new Vector3(0f, 0f, -0.083f);
                    Instantiate(graphite, point, transform.rotation);
                }
            }
        }
        */
    }
}
