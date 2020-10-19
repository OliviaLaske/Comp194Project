using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Transform RightHandAnchor;
    public GameObject canvas;
    public Button next;

    void OnClick()
    {
        SceneManager.LoadScene("Classroom");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(RightHandAnchor.transform.position, RightHandAnchor.transform.forward * 10.0f);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == "Next")
            {
                if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
                {
                    hit.collider.gameObject.GetComponent<Button>().onClick.Invoke();
                }
            }
        }
    }
}
