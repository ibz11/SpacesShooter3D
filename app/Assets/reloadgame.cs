using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
//using TMPro;

public class reloadgame : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
  void OnCollisionEnter(Collision col)
    {
    
  if (col.gameObject.tag == "asteroid"){
      print("Asteroid Hit.Restart Game...");
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
   else if (col.gameObject.tag == "alien"){
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   print("Alien hit you win");
   }
   else{
   
    print("Continue playing");
   }
}}
