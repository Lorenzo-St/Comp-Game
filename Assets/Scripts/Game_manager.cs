using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_manager : MonoBehaviour
{

    // GameObjects
    public GameObject Player;
    
    // Data Holders
    public int score;
    public float Time_left = 60f;
    public int min = 4;
    
    // GUI Stuff
    [SerializeField]
    private Text Score_Display;

    [SerializeField] 
    private Text Time_Display;
    
    
    // Bool
    public bool isPaused;
    public bool FreePlay;
    
    CursorLockMode wantedMode;
    
    

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
                if (Time_left < 0)
                {
                    min -= 1;
                    Time_left = 60;
                    if (min <= 0)
                    {
                        GameOver();
                    }
                }
            }
        }


         int sec = Mathf.RoundToInt(Time_left);

         Time_Display.text = "Time: " + min + ":" + sec;
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
        
    }
}
