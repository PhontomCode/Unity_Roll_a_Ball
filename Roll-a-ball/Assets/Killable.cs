using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Killable : MonoBehaviour {
    public Vector3 origin;
    private Rigidbody rigidbody;
    public void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        origin = transform.position;
    }

    public void Death()
    {
        transform.position = origin;
        rigidbody.velocity = Vector3.zero;
    }
    // Use this for initialization
}
