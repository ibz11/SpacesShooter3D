using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class portalcollision : MonoBehaviour
{
    // Start is called before the first frame update
    //public AudioSource portalphase;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      void OnCollisionEnter(Collision col)
    {
     
    if (col.gameObject.tag == "portal")
        {
        //  portalphase.Play();
         print("Portal  Entered.Load next level");
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           // Destroy(gameObject);
        }
         else if (col.gameObject.tag == "asteroid"){
        print("Asteroid Hit.Restart Game...");
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    else{
      print("Game Over");
    }

}


     







}

