﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    public List<GameObject> list;
    public Transform Destination;       // Gameobject where they will be teleported to
    public string TagList = "|Player|Boss|Friendly|"; // List of all tags that can teleport

    public void OnTriggerEnter(Collider other)
    {
        // If the tag of the colliding object is allowed to teleport
        if (TagList.Contains(string.Format("|{0}|", other.tag)))
        {
            // Update other objects position and rotation
            other.transform.position = Destination.transform.position;
            other.transform.rotation = Destination.transform.rotation;
        }
    }
}