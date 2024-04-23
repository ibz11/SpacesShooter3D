using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class bullet : MonoBehaviour
{
  
//     public GameObject mine;
  
//     // Start is called before the first frame update
//    public float life = 3;
 
    // void Awake()
    // {
    //     Destroy(mine, life);
    // }

    // void OnCollisionEnter(Collision Col)
    // {


     public void OnTriggerEnter(Collider Col)
    {

         if (Col.gameObject.tag == "alien"){
        // Destroy(collision.gameObject);
        // Destroy(gameObject);
      
           Col.gameObject.SetActive(false);
         //Destroy(mine, life);
        
          print("Alien destroyed");
   }

 // mine.SetActive(true);


    }

  
}
