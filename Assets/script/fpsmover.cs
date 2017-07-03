using System.Collections;
using UnityEngine;
using myshit;


public class fpsmover: Controller {

	public float speed = 6.0f;
	public float jumpForce = 8.0f;
	public float gravity = 20.0f;
	//public bool isJumping;
	private Vector3 moveDirection = Vector3.zero;

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			//Jump();
		}
		else{
		}
				
	}

//	public override float Jump(){
		

//	}


}



public class asdf{

	public float asd;

}