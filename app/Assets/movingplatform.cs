using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
// public float rightLimit = 2.5f;
// // public float leftLimit = 1.0f;
//   public float speed;

//     // Start is called before the first frame update
    

//     // Update is called once per frame
//     void Update()
//     {  

//         // transform.Translate(Vector2.right * speed * Time.deltaTime);
//     if (transform.position.x > 0){
// transform.Translate(Vector2.left * speed * Time.deltaTime);   
//      if (transform.position.x == -30)
//         {
//  transform.Translate(Vector2.right * speed * Time.deltaTime);
//         }    
//     }
    

private Vector2 startPosition;

private Vector2 newPosition;


public int speed ;

 public int maxDistance ;

void Start()
{
startPosition = transform.position;
    newPosition = transform.position;
}

void Update()
{
    

    newPosition.x = startPosition.x + (maxDistance * Mathf.Sin(Time.time * speed));
    transform.position = newPosition;
}










    }






    
     

