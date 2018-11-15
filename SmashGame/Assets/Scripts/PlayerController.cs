using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float maxSpeed = 1;
    public float jumpMultiplier = 1;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");

        rb.velocity = new Vector3(move * maxSpeed, rb.velocity.y, rb.velocity.z);

        if (jump > 0 )
        {
            rb.velocity = new Vector3(rb.velocity.x, jump * jumpMultiplier, rb.velocity.z);
        }
    }
}
