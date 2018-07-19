using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour {

	public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Killable>())
        {
            other.gameObject.GetComponent<Killable>().origin = transform.position;
        }
    } 
}
