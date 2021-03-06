using System.Collections;
using UnityEngine;

namespace myshit{
	public class Controller: MonoBehaviour {
		public float jumpVelocity;

		public float speed;
		float moveHorizontal;
		float moveVertical;
		float moveUp;
		private Rigidbody rg;

		void Start(){
			rg = GetComponent<Rigidbody> ();
		}

		void Update(){
			 moveHorizontal = Input.GetAxis ("Horizontal");
			 moveVertical = Input.GetAxis ("Vertical");
			 moveUp = Input.GetAxis ("Fire1");

		}


		void FixedUpdate(){

			float jumpAmt = Jump ();
			Vector3 movement = new Vector3 (moveHorizontal, jumpAmt,  moveVertical);
			rg.AddForce(movement *speed);

		}

		public virtual float Jump(){
			float ground = 0.0f;

			if (Input.GetButtonDown ("Jump")) {
				rg.velocity = Vector3.up * jumpVelocity;

				//Debug.Log ("goodbye");
			}
			return ground;
		}
	}
}
