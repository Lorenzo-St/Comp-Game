using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Object_Controller : MonoBehaviour
{
    // connections
    private Rigidbody Self;
    [SerializeField] 
    private Game_manager GM;
    
    // DataHolders
    public float StartingX;
    public float StartingY;
    public float StartingZ;
    public int points_To_Give;
    
    // Bools
    public bool was_hit = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        was_hit = false;
        Self = GetComponent<Rigidbody>();
        Self.transform.position = new Vector3(StartingX, StartingY, StartingZ);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!was_hit)
            {
                GM.score += points_To_Give;
                was_hit = true;
            }

            if (was_hit)
            {
                GM.score += points_To_Give / 10;

            }
        }
            
    }
}
