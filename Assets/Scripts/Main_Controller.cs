using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Controller : MonoBehaviour
{

    [SerializeField] 
    private GameObject Start_Screne,Options;
    
    // Start is called before the first frame update
    void Start()
    {
        Start_Screne.SetActive(true);
        Options.SetActive(false);
    }

    public void BeginGame()
    {
        SceneManager.LoadScene("GameWorld");
        Start_Screne.SetActive(false);
        Options.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void options()
    {
        Options.SetActive(true);
        Start_Screne.SetActive(false);
    }

    public void Main_Button()
    {
        Options.SetActive(false);
        Start_Screne.SetActive(true);     
    }
}
