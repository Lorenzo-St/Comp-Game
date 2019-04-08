using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Game_manager : MonoBehaviour
{
    public GameObject Player;
    
    public int score;
    
    public bool isPaused;
    
    CursorLockMode wantedMode;
    
    
    // Start is called before the first frame update
    void Start()
    {
        wantedMode = CursorLockMode.Locked;
        isPaused = false;
        score = 0;
    }

    // Update is called once per frame
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
        }

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
}
