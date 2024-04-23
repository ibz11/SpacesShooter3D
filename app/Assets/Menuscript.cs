using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menuscript : MonoBehaviour
{

    public string firstlevel;
    // Start is called before the first frame update
   //public  GameObject click;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void StartGame(){
SceneManager.LoadScene(firstlevel);
}

 public void LoadMenu()

{
   // click.gameObject.SetActive(true);
        Time.timeScale = 1f;
      
      SceneManager.LoadScene("Main Menu");
}

public void QuitGame(){
Application.Quit();
Debug.Log("Quitting");
}


}
