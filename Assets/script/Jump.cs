using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	// Use this for initialization
	[Range(1,10)]
	public float jumpVelocity;

	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			GetComponent<Rigidbody> ().velocity = Vector3.up * jumpVelocity;
		}
	}
}
