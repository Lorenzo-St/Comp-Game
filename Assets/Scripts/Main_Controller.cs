using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Controller : MonoBehaviour
{

    [SerializeField] 
    private GameObject Start_Screne,Options,mode_Select;

    public Game_manager GM;
    // Start is called before the first frame update
    void Start()
    {
        Start_Screne.SetActive(true);
        Options.SetActive(false);
        mode_Select.SetActive(false);
    }

    public void normalGame()
    {
        SceneManager.LoadScene("GameWorld");
        Start_Screne.SetActive(false);
        Options.SetActive(false);
        mode_Select.SetActive(false);
        GM.FreePlay = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void options()
    {
        Options.SetActive(true);
        Start_Screne.SetActive(false);
        mode_Select.SetActive(false);
    }

    public void Main_Button()
    {
        Options.SetActive(false);
        Start_Screne.SetActive(true);    
        mode_Select.SetActive(false);
    }
    public void Mode_Select() {
        Options.SetActive(false);
        Start_Screne.SetActive(false);
        mode_Select.SetActive(true);
        
    }

    public void Freeplay()
    {
        SceneManager.LoadScene("GameWorld");
        Start_Screne.SetActive(false);
        Options.SetActive(false);
        mode_Select.SetActive(false);
        GM.FreePlay = true;
    }
}
