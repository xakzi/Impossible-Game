using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{/*
    public float JumpStrength = 3f, SpeedStrength = 2f;


    bool canJump = false;
    bool canWalk = false;

    private float GetVelocityY;

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
            canWalk = false;
        }
    }

    private void FixedUpdate()
    {
        if(canWalk == false)
        {
            GetVelocityY = rb.velocity.y;
            rb.velocity = new Vector3(SpeedStrength, GetVelocityY);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        Vector3 hit = collision.contacts[0].normal;
        Debug.Log(hit);
        float angle = Vector3.Angle(hit, Vector3.up);

       
        if(Mathf.Approximately(angle,180))
        {
            //Up
            Debug.Log("Up");
        }
       

        if(collision.gameObject.tag == "Ground")
        {
            if (Mathf.Approximately(angle, 0))
            {
                //Down
                Debug.Log("Down");
                canJump = true;
            }
            
        }

        if(collision.gameObject.tag == "Wall")
        {
            if (Mathf.Approximately(angle, 90))
            {
                
                Vector3 cross = Vector3.Cross(Vector3.forward, hit);
                if (cross.y > 0)
                {
                    //left
                    Debug.Log("Left");
                    canWalk = true;
                    canJump = true;
                }
                else
                {
                    //right
                    Debug.Log("Right");
                    canWalk = true;
                    canJump = true;
                }
                
            }
            if (Mathf.Approximately(angle, 0))
            {
                //Down
                Debug.Log("Down");
                canJump = true;
            }

        }
    }*/
}
