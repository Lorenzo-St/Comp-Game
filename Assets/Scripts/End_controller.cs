using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End_controller : MonoBehaviour
{

    [SerializeField] 
    private Game_manager GM;

    public Text Score_dis;

    public int Score;
    
    CursorLockMode wantedMode;

    void Start()
    {
        Score_dis.text = "Score: " + Score;
        wantedMode = CursorLockMode.None;
    }

    void Update()
    {
        Score_dis.text = "Score: " + Score;
        SetCursorState();
    }

    public void Return() {
        
        SceneManager.LoadScene("MainMenu");
        
    }
    void SetCursorState()
    {
        Cursor.lockState = wantedMode;
        Cursor.visible = (CursorLockMode.Locked != wantedMode);
    }
}
