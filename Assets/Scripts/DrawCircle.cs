using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCircle : MonoBehaviour
{
    public OVRInput.Controller controller;
    private LineRenderer lineRenderer;
    private GameObject drawPoint;
    private GameObject lineRendererParent;

    private bool drawing;
    
    public Transform RightHandAnchor; // Potentially Transform class?
   // public GameObject pencil;

   Vector3 startPoint;

    void start()
    {
        lineRenderer = RightHandAnchor.GetComponent<LineRenderer>();
    }
    private void Drawing()
    {
        if (Input.GetAxis("Oculus_CrossPlatform_PrimaryHandTrigger")>0.2f)
        {
           // Drawing();
            drawing = true;
            lineRendererParent = new GameObject();
            lineRendererParent.transform.position = transform.position;
            lineRenderer = lineRendererParent.AddComponent<LineRenderer>();
            lineRenderer.startWidth = 0.01f;
            
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 1.0f))
            {
                if(hit.transform.tag == "Paper")
                {
                    startPoint = hit.point;
                    lineRenderer.SetPosition(0, startPoint);
                    if(drawing == true)
                    {
                        lineRenderer.SetPosition(1, hit.point);
                    }
                }
            }
            
           // lineRenderer.SetPosition(0, drawPoint.transform.position);
            // lineRenderer.SetPosition(1, hit.point); // drawPoint.transform.position);
        }
            // if (drawing == true)
            // {
                // lineRenderer.SetPosition(lineRenderer.positionCount++, drawPoint.transform.position);
            // }

            // if(drawing == true)
            // {
                // lineRenderer.SetPosition(1, hit.point);
            // }
    }

}
