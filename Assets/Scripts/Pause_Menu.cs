using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause_Menu : MonoBehaviour
{
    // Script Connections
    private Game_manager GM;

    [SerializeField] 
    private GUI_Manager GUI;
    // GameObjects
    public GameObject PauseMenu;
    
    // UI Stuff
    public Text Score;
    void Start()
    {
        GM = GetComponent<Game_manager>();
        PauseMenu.SetActive(false);
    }

    void Update()
    {
        if (GM.isPaused)
        {
            PauseMenu.SetActive(true);
        }else if (GM.isPaused == false)
        {
            PauseMenu.SetActive(false);
        }

        Score.text = "Score: " + GM.score;
    }


    public void UnPause()
    {
        GM.isPaused = false;
        GUI.GUI.SetActive(true);
    }
    public void CloseGame() 
    {
        Application.Quit();    
    }

    public void Go_Home()
    {
        SceneManager.LoadScene("MainMenu");
        PauseMenu.SetActive(false);
    }
}
