using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour {

private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Scorekeeper>())
        {
            other.GetComponent<Scorekeeper>().score++;
            
            Destroy(this.gameObject);
        }
    }



}
