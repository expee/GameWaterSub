using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float bodySpeed;
    public float tilt;
	private Rigidbody rb;
	// Use this for initialization
	void Start ()
	{
        rb = gameObject.GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
        float moveVer = Input.GetAxis("Vertical");
        float moveHor = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHor, moveVer, 0.0f);
        rb.velocity = movement * bodySpeed;
        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * tilt);
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}
