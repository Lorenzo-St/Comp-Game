using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    private player_motor PM;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        PM = GetComponent<player_motor>();
    }

    
    
    // Update is called once per frame
    void Update()
    {
        PerformMove();
    }

    public void PerformMove()
    {
        
        
    }
}
