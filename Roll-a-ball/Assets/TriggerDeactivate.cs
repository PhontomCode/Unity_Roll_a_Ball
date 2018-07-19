using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeactivate : MonoBehaviour {

    public List<GameObject> list;

    public void OnTriggerEnter(Collider other)
    {

            foreach(var ob in list)
            {
                ob.SetActive(false);
            }
    }
}
