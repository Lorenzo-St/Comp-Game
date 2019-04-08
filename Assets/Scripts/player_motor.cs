using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class player_motor : MonoBehaviour
{
    // Script Connects
    private player_controller PC;
    [SerializeField] 
    private Game_manager GM;
    
    // Vectors
    private Vector3 velocity = Vector3.zero;
    private Vector3 rotation = Vector3.zero;


    // Components and GameObjects
    private Rigidbody RB;
    [SerializeField]
    private Camera Cam;

    // Data Handlers
    [SerializeField]
    private float CameraRotationLimit = 85f;
    private float CamRotateX = 0f;
    private float currCamRotX = 0f;


    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Gets Movement Vectors
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }
    // Gets Rotation Vector
    public void Rotate(Vector3 _rotation)
    {
        rotation = _rotation;
    }
    // Gets Camera Rotation
    public void RotateCamera(float _CameraRotationX)
    {
        CamRotateX = _CameraRotationX;
    }

    // Do Physics iterations
    private void FixedUpdate()
    {
            PerformMovement();
            PerformRotation();
    }

    // Perform Movement based on velocity variable
    void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            RB.MovePosition(RB.position + velocity * Time.fixedDeltaTime);
        }
    }

    // Performs Rotations
    void PerformRotation()
    {
        RB.MoveRotation(RB.rotation * Quaternion.Euler(rotation));
        if (Cam != null)
        {
            currCamRotX -= CamRotateX;
            currCamRotX = Mathf.Clamp(currCamRotX, -CameraRotationLimit, CameraRotationLimit);

            Cam.transform.localEulerAngles = new Vector3(currCamRotX, 0f, 0f);
        }
    }
}
