using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountStudents : MonoBehaviour
{
    public GameObject Canvas;
    TextMeshPro Numbers;
    int Counter = 0;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(5.0f);
    }

    // Start is called before the first frame update
    void Start()
    {
        Numbers = Canvas.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 17; i++)
        {
            Counter = 0;
            Numbers.text = Counter.ToString("0");
            if(Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f || Input.GetAxis("Oculus_CrossPlatform_SecondaryIndexTrigger") > 0.2f)
            {
                if(Counter == 0)
                {
                    Counter = 1;
                    Numbers.text = Counter.ToString("1");
                }
                else if(Counter == 1)
                {
                    Counter = 2;
                    Numbers.text = Counter.ToString("2");
                }
                else if(Counter == 2)
                {
                    Counter = 3;
                    Numbers.text = Counter.ToString("3");
                }
                else if(Counter == 3)
                {
                    Counter = 4;
                    Numbers.text = Counter.ToString("4");
                }
                else if(Counter == 4)
                {
                    Counter = 5;
                    Numbers.text = Counter.ToString("5");
                }
                else if(Counter == 5)
                {
                    Counter = 6;
                    Numbers.text = Counter.ToString("6");
                    // play audio
                    StartCoroutine(WaitForSeconds());
                }
            }
        }
    }
}
