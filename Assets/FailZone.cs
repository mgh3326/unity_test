using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour {
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name=="Ball")
        {
#pragma warning disable CS0618 // Type or member is obsolete
            Application.LoadLevel(name: "Game");
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
