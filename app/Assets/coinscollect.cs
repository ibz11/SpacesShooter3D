using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class coinscollect : MonoBehaviour
{
    //public int coins { get; private set; }
       public int coins;
       public TextMeshProUGUI scoreText;
     public AudioSource coincollect;

  
    // Start is called before the first frame update
    
   //
//    private void OnTriggerEnter(Collider col)
// void OnCollisionEnter(Collision col)
//     {
     
//     if (col.gameObject.tag == "coin")
//         {
//         print("Coin collected...");
//         coins=coins+1;
//         col.gameObject.SetActive(false);
//         Destroy(col.gameObject);

//         }
        
//     }



     public void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "coin")

        {
            coincollect.Play();
            Debug.Log("Coin collected!");
            coins = coins + 1;
            Col.gameObject.SetActive(false);
            print(coins);
            scoreText.text= coins.ToString(); 

       
         }


    }











}
