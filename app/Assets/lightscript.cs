using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightscript : MonoBehaviour
{

    float duration=5.0f;
    public Light myLight;
    // Color color0=Color.red;
    // Color color1=Color.white;
    // color color0=Color.red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      myLight.intensity=Mathf.PingPong(Time.time ,0.7f);  

      
      // float t=Mathf.PingPong(Time.time,duration)/duration;
      // myLight.color=Color.Lerp(color0,color1,t);
    }

    // void OnTriggerEnter(Collider other){

    //     myLight.intensity=Mathf.PingPong(Time.time ,0.2f);
    // }
}
