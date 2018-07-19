using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBehavior : MonoBehaviour{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Killable>())
        {
            other.gameObject.GetComponent<Killable>().Death();

        }
    }
}
