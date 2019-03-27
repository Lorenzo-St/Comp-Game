using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_motor : MonoBehaviour
{

    private player_controller PC;
    
    public float speed = 5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PC = GetComponent<player_controller>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
