using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_Manager : MonoBehaviour
{
    // GameObjects
    public GameObject GUI;
    
    // Connections
    [SerializeField] 
    private Game_manager GM;
    // Start is called before the first frame update
    void Start()
    {
        GUI.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GM.isPaused)
        {
            GUI.SetActive(false);
        }
//        if (!GM.isPaused)
//        {
//            GUI.SetActive(true);
//        }
    }
}
