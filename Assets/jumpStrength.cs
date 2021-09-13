using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpStrength : MonoBehaviour
{
    public float upForce = 150f;
    private Rigidbody rb;
    bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && canJump == true)
        {
            
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, upForce));
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
