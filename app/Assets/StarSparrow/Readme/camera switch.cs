using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    //We declare the three cameras within our scene
    public Camera camera1;
    public Camera camera2;

    void Start()
    {
        //We initialize the states of each camera
        camera1.enabled = true;
        camera2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //on pressing a key "s" it negates the state of each camera thereby switching in between them
        if (Input.GetKey("s"))
        {
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}