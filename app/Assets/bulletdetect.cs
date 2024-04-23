using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class bulletdetect : MonoBehaviour
{
    // Start is called before the first frame update


    //    public int coins;
    //    public TextMeshProUGUI scoreText;

    
    //    void OnCollisionEnter(Collision col)
    // { 
    public void OnTriggerEnter(Collider col){
     
    if (col.gameObject.tag == "bullet")
        {

       // col.gameObject.SetActive(false);
       //  Destroy(col.gameObject, 1);
         print("object hit");
        //  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
           // Destroy(gameObject);


         }

}
}
