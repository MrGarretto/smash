using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StretchMario : MonoBehaviour {

    Rigidbody marioRB;

	// Use this for initialization
	void Start () {
        marioRB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //marioRB.rotation = Random.rotation;
        transform.position.Set(transform.position.x, transform.position.y + 1f, transform.position.z);
	}
}
