using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class alienPoint : MonoBehaviour
{
    
     public int points;
      public TextMeshProUGUI scoreText;
     public AudioSource scoresound;
    
    
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTriggerEnter(Collider Col){

    
          if (Col.gameObject.tag == "alien"){
            points= points+ 5;
            Col.gameObject.SetActive(false);
            print(points);
            scoreText.text= points.ToString(); 

        }
        }
}
