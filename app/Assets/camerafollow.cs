using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
      // Start is called before the first frame update

    //We need to declare two things:
    //1. An offset: Distance between the camera and the player that will be maintained during camera follow event
    //2. The player: who/what are following

    public Vector3 offset;
    public GameObject player;
    void Start()
    {
     offset = transform.position - player.transform.position;   
    }

    // Update is called once per frame
    void Update()
    {
         //we update the position of the camera continuously as the game is playing within the update function
        transform.position = player.transform.position + offset;
    }
}
