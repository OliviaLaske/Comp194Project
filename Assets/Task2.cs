using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    void OnTriggerEnter (Collider penStand) 
    { 
        if (penStand.GetComponent<Pen> () !=null) 
        {
            Debug.Log("Task Complete"); 
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
 /*public Transform target;
 void Update()
 {
     Vector3 targetDir = target.position - transform.position;
     float angle = Vector3.Angle(targetDir, transform.forward);
 }
  */ 
}
