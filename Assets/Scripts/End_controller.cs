using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class End_controller : MonoBehaviour
{

    [SerializeField] 
    private Game_manager GM;

    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Score: " + GM.score;
    }

    public void Return() {
        
        SceneManager.LoadScene("MainMenu");
        
    }
}
