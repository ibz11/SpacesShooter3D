using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclemovement : MonoBehaviour
{     
    public float delta = 80.5f;  // Amount to move left and right from the start point
     public float speed = 100.0f; 
     private Vector3 startPos;

    void Start()
    {
       startPos = transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 v = startPos;
         v.x += delta * Mathf.Sin (Time.time * speed);
         transform.position = v;

    }
}


 
