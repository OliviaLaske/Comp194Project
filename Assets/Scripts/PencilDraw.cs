using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilDraw : MonoBehaviour
{
    TrailRenderer graphite = new TrailRenderer();

    // Start is called before the first frame update
    void Start()
    {
        TrailRenderer graphite = gameObject.GetComponent<TrailRenderer>();
        graphite.enabled = false;
        graphite.startWidth = 0.1f;
        graphite.endWidth = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            graphite.enabled = true;
        }
        else
        {
            graphite.enabled = false;
        }
    }
}
