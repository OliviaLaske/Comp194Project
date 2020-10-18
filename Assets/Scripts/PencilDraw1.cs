using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PencilDraw1 : MonoBehaviour
{
    public Transform RightHandAnchor;
    public GameObject pencil;
    public GameObject graphite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
        {
            Ray ray = new Ray(RightHandAnchor.transform.position, pencil.transform.forward + new Vector3(0f, 0f, 0.1f));
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Instantiate(graphite, pencil.transform.position + new Vector3(0f, 0f, -0.08f), pencil.transform.rotation);
            }
        }
    }
}
