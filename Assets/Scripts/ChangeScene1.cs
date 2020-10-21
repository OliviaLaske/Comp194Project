using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ChangeScene1 : MonoBehaviour
{
    public int index;
    public TextMeshPro press;

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(27.5f);
        press.text = "Press B to continue";
    }

    // Start is called before the first frame update
    void Start()
    {
        press.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.Two))
        {
            SceneManager.LoadScene(index);
        }
    }
}
