using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidfield : MonoBehaviour
{
  public   Transform asteroid;
  public int fieldradius=100;
  public int asteroidCount=500;




    void Start()
    {
        for(int loop=0;loop<asteroidCount; loop++){
            Instantiate(asteroid,Random.insideUnitSphere*fieldradius,Quaternion.identity);     
               }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
