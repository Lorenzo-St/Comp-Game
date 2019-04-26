using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class AI_controller : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    
    // script connections
    [SerializeField]
    private Game_manager Gm;
    void Start () {
         agent = GetComponent<NavMeshAgent>();

    }

    private void FixedUpdate()
    {
        if (!Gm.isPaused)
        {
            agent.destination = goal.position;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
           Gm.GameOver();
           Debug.Log("GameOver: Reason Caught");
        }
    }
}
