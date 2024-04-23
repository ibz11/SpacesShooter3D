using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenuscript : MonoBehaviour
{
  public static bool GameIsPaused = false;
  public GameObject pauseMenuUI;
public AudioSource click;
public GameObject bgmusic;

// Scene m_Scene;
//   string sceneName;

    void Update()
    {//Input.GetKeyDown(KeyCode.Escape)
        if (Input.GetKeyDown("p"))
        {
            click.Play();
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                 //click.Play();
                Pause();
            }
        }
    }

    public void Resume ()
    {
        bgmusic.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
  
    void Pause ()
    {
         bgmusic.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public  void Restart ()
    {
       
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void LoadMenu()

    {
         click.Play();
        Time.timeScale = 1f;
      
      SceneManager.LoadScene("Main Menu");

    // Debug.Log("Loading menu");
    //
    // m_Scene = SceneManager.GetActiveScene();
    //  sceneName = m_Scene.name;
    // Debug.Log(sceneName);
    }
    public void QuitGame()
    {   
         click.Play();
        Time.timeScale = 1f;
        Debug.Log("Quitting game...");
        // Application.Quit();
        SceneManager.LoadScene("Main Menu");
    }

}
