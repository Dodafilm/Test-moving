using System.Collections;
using UnityEngine;

public class Controller: MonoBehaviour {

	public float jumpVelocity;
	public float speed;
	float jumpAmt;
	float moveHoriztonal;
	float moveVertical;

	private Rigidbody rg;

	void Start(){
		rg = GetComponent<Rigidbody> ();

	}

	void Update(){
		moveHoriztonal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
		jumpAmt = Jump ();
	}

	void FixedUpdate(){
		Vector3 movement = new Vector3 (moveHoriztonal, jumpAmt, moveVertical);
		rg.AddForce (movement * speed);
	}

	public float Jump(){
		float Jump = 2.0f;
		if (Input.GetButtonDown ("Jump")) {
			rg.velocity = Vector3.up * jumpVelocity;
		}
		return Jump;
	}

}