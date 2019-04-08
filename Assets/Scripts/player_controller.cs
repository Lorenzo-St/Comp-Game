using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(player_motor))]
public class player_controller : MonoBehaviour
{

    // Connections
    private player_motor PM;
    private CapsuleCollider Collider;
    private Rigidbody RB;

    // Data Holders
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lookSensitivity = 3f;
    public float jumpSpeed = 8f;
    private bool IsGrounded;
    


    // Start is called before the first frame update
    void Start()
    {
        PM = GetComponent<player_motor>();
        Collider = GetComponent<CapsuleCollider>();
        RB = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        // Calculate movement velocities
        float _Xmove = Input.GetAxisRaw("Horizontal");
        float _Ymove = Input.GetAxisRaw("Vertical");

        Vector3 _movHorizontal = transform.right * _Xmove;
        Vector3 _movVertical = transform.forward * _Ymove;

        // Final Move Vector
        Vector3 _velocity = (_movHorizontal + _movVertical).normalized * speed;

        // Apply Movement
        PM.Move(_velocity);

        // Calculate rotation vectors
        float _Yrot = Input.GetAxisRaw("Mouse X");

        Vector3 _rotation = new Vector3(0f, _Yrot, 0f) * lookSensitivity;

        PM.Rotate(_rotation);

        // Calculate Camera Rotations
        float _Xrot = Input.GetAxisRaw("Mouse Y");

        float _cameraRotationX = _Xrot * lookSensitivity;

        //apply Camera Rotation
        PM.RotateCamera(_cameraRotationX);

        // Jump
        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            RB.velocity = new Vector2(RB.velocity.x, jumpSpeed);
            IsGrounded = false;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            IsGrounded = true;
        }
    }

}
