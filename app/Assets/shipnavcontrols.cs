using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipnavcontrols : MonoBehaviour
{
    public float forwardSpeed=25f,strafeSpeed=7.5f,hoverSpeed=5f;
private float activeforwardSpeed,activestrafeSpeed,activehoverSpeed;
private float forwardAcceleration=2.5f,strafeAcceleration=2f,hoverAcceleration=2f;



void Start()
{

}

    // Update is called once per frame
    void Update()
    {
     
    // lookInput.x=Input.mousePosition.x;
    // lookInput.y=Input.mousePosition.y;

    // mouseDistance.x=(lookInput.x-screenCenter.x)/screenCenter.y;
    // mouseDistance.y=(lookInput.y-screenCenter.y)/screenCenter.y;
    // mouseDistance=Vector2.ClampMagnitude(mouseDistance,1f);
    
    // transform.Rotate(-mouseDistance.y * rotatespeed * Time.deltaTime  , mouseDistance.x * rotatespeed * Time.deltaTime  ,0f,Space.Self);

    activeforwardSpeed=Mathf.Lerp(activeforwardSpeed,Input.GetAxisRaw("Vertical") * forwardSpeed,forwardAcceleration*Time.deltaTime);
    activestrafeSpeed=Mathf.Lerp(activestrafeSpeed,Input.GetAxisRaw("Horizontal") * strafeSpeed,strafeAcceleration*Time.deltaTime);
    activehoverSpeed=Mathf.Lerp(activehoverSpeed,Input.GetAxisRaw("Hover") * hoverSpeed,hoverAcceleration*Time.deltaTime);

    transform.position += transform.forward * activeforwardSpeed*Time.deltaTime;
    transform.position += (transform.right * activestrafeSpeed * Time.deltaTime) +(transform.up * activehoverSpeed * Time.deltaTime);

    //  Vector3 forward = transform.forward * activeforwardSpeed * Time.fixedDeltaTime;
    //     Vector3 strafe = transform.right * activestrafeSpeed * Time.fixedDeltaTime;
    //     Vector3 hover = transform.up * activehoverSpeed * Time.fixedDeltaTime;

    //     Vector3 movement = forward + strafe + hover;
    //     gameObject.GetComponent<Rigidbody>().MovePosition(transform.position + movement);


    }
}
