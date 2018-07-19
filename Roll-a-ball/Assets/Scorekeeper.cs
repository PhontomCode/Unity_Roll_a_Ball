using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour {

    public int levelIndex;
    public int score;
    public int Victoryscore;
	// Use this for initialization
	void Start () {
        Victoryscore = FindObjectsOfType<PickupBehavior>().Length;
	}
	
	// Update is called once per frame
	void Update () {
		if(score >= Victoryscore)
        {
            SceneManager.LoadScene(levelIndex);
        }
	}

}
