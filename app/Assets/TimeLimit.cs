using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{

    public float timeRemaining = 21;
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            double time = Math.Round(timeRemaining);
            //Debug.Log(timeRemaining);
            timerText.text = time.ToString();
        }
        else
        {
            Debug.Log("Time has run out!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
