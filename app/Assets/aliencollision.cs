using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class aliencollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//   public void OnTriggerEnter(Collider col){
//void OnCollisionEnter(Collision col){
    public void OnTriggerEnter(Collider col){
    if (col.gameObject.tag == "alien"){
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   print("Alien hit you.You lose");
   }
   }
}
