using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public KeyCode forward, backward, right, left;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(forward)) {
			rb.AddForce (new Vector3(0, 0, 25));
		}
		if (Input.GetKey(backward)) {
			rb.AddForce (new Vector3(0, 0, -25));
		}
		if (Input.GetKey(left)) {
			rb.AddForce (new Vector3(-25, 0, 0));
		}
		if (Input.GetKey(right)) {
			rb.AddForce (new Vector3(25, 0, 0));
		}
	}
}
