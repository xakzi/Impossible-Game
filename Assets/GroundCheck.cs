using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GroundCheck : MonoBehaviour
{
    public float JumpStrength = 3f;
    bool canJump = false;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown("space") && canJump == true)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, JumpStrength));
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }
}
