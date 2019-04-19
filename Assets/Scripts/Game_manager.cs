using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Game_manager : MonoBehaviour
{

    // GameObjects
    public GameObject Player;
    
    // Data Holders
    public int score;
    public float Time_left = 59f;
    public int min = 4;
    
    // GUI Stuff
    [SerializeField]
    private Text Score_Display;

    [SerializeField] 
    private Text Time_Display;

    [SerializeField] 
    private Text HighScore;
    
    
    // Bool
    public bool isPaused;
    public bool FreePlay;
    
    CursorLockMode wantedMode;
    
    // Connections 
    [SerializeField] 
    private Score_Controller SC;
    
    

    void Start()
    {
        wantedMode = CursorLockMode.Locked;
        isPaused = false;
        score = 0;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            min = 0;
            Time_left = 10;
        }

        if (isPaused)
        {
            Paused();
        }
         if(isPaused == false)
        {
            wantedMode = CursorLockMode.Locked;
            if (FreePlay == false)
            {
                Time_left -= Time.deltaTime;
                if (min == 0 && Time_left <= 0)
                {
                    GameOver();
                    SC.Write();
                }
                if(Time_left <= -1){
                    min -= 1;
                    Time_left = 59;

                }
                int sec = Mathf.RoundToInt(Time_left);
                if(sec>9)
                    Time_Display.text = "Time " + min + ":" + sec;
                if (sec <= 9)
                    Time_Display.text = "Time " + min + ":0" + sec; 
            }
            
        }

         if (FreePlay)
         {
             Time_Display.text = "Time ∞";
         }

         HighScore.text = SC.HigherScore.ToString();
         Score_Display.text = score.ToString();
        SetCursorState();
    }


    void Paused()
    {
        wantedMode = CursorLockMode.None;
    }
    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }

    void GameOver()
    {
        SceneManager.LoadScene("EndGame");
        wantedMode = CursorLockMode.None;
    }
}
