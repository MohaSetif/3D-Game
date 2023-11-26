using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
     Rigidbody rb;
    [SerializeField] readonly float movementSpeed = 8f;
    [SerializeField] readonly float jumpForce = 5f;

    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;

    [SerializeField] AudioSource jumpSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        jumpSound.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy Head"))
        {
            Destroy(collision.transform.parent.gameObject);
            Jump();
        }
    }

    bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, .1f, ground);
    }
}

        // if(Input.GetKeyDown("space")){
        //     rb.velocity = new Vector3(0, 5, 0);
        // }
        // else if(Input.GetKey("up")){
        //     rb.velocity = new Vector3(0, 0, 5);
        // }
        // else if(Input.GetKey("down")){
        //     rb.velocity = new Vector3(0, 0, -5);
        // }
        // else if(Input.GetKey("right")){
        //     rb.velocity = new Vector3(5, 0, 0);
        // }
        // else if(Input.GetKey("left")){
        //     rb.velocity = new Vector3(-5, 0, 0);
        // }