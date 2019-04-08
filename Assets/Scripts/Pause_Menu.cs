using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu : MonoBehaviour
{

    private Game_manager GM;

    public GameObject PauseMenu;
    
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
    }


    public void UnPause()
    {
        GM.isPaused = false;
    }
}
