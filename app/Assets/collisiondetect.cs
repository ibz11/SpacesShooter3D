using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisiondetect : MonoBehaviour
{
public GameObject portal;

void Start(){

}

void Update(){

}


void onCollisonEnter(Collision collision){
  
// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
Debug.Log("Entering collision detection");
Destroy(portal,2);
    
}

}



