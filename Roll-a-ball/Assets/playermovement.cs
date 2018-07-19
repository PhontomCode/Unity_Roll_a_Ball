using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {


    public Rigidbody rigidbody;

    public float speed;
    public float jumpforce;
    private bool canJump;
    
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rigidbody.AddForce(new Vector3(h, 0, v) * speed);
        if (canJump && Input.GetAxis("Jump") > 0)
        {
            rigidbody.AddForce(new Vector3(0, 1, 0) * jumpforce * 1000);
            canJump = false;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        canJump = true;
    }
}
