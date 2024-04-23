using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour
{


        public float amplitude = .2f;
    public float speed = .3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Vector3 p = transform.position;
    //   p.y = Mathf.Cos(Time.time);
    //   transform.position = p; 
    Vector3 p = transform.position;
      p.y = amplitude * Mathf.Cos(Time.time * speed);
      transform.position = p;
    }
}
