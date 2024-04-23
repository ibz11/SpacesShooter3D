using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingscript : MonoBehaviour
{
    // Start is called before the first frame update
   public AudioSource shoot;
   // public AudioSource aliensound;
   // public AudioSource aliensound;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetKeyDown("l"))
        {  shoot.Play();
         

        } 
    }
}
