using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


public float forwardSpeed=25f,strafeSpeed=7.5f,hoverSpeed=5f;
private float activeforwardSpeed,activestrafeSpeed,activehoverSpeed;




    void Update()
    {
        activeforwardSpeed=Input.GetAxisRaw("Vertical")*forwardSpeed;
        activestrafeSpeed=Input.GetAxisRaw("Horizontal")*strafeSpeed;
        activehoverSpeed=Input.GetAxisRaw("Hover")*hoverSpeed;

        transform.position += transform.forward * activeforwardSpeed*Time.deltaTime;
        
    }












    
    }

