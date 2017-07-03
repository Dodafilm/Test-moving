using System.Collections;
using UnityEngine; 

public class Move : MonoBehaviour{

	public float jumpVelocity;

	public float speed;

	float moveHoriztonal;
	float moveVertical;

	private Rigidbody rg;

	void Start(){
		rg = GetComponent<Rigidbody> ();

	}

	void Update(){
		moveHoriztonal = Input.GetAxis ("Horizontal");
		moveVertical = Input.GetAxis ("Vertical");
	}

	void FixedUpdate(){
		float jumpAmt = Jump ();
		Vector3 movement = new Vector3 (moveHoriztonal, jumpAmt, moveVertical);
		rg.AddForce (movement * speed);

	}

	public virtual float Jump(){

		float ground = 0.0f;

		if (Input.GetButtonDown ("Jump")) {
			rg.velocity = Vector3.up * jumpVelocity;
		}
		return ground;
	}

}