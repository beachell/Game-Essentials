using UnityEngine;
using System.Collections;

public class CharacterControllerScript : MonoBehaviour {
	
	public int currentJumpNum = 0; 
	public int maxJump = 2;
	public float maxS = 2f;
	bool right = true;
	public float jumpHeight = 3f;
	float moveVelocity;

	public int notMovingSpeed = -4;




	void FixedUpdate()
	{

		transform.Translate (new Vector3 (notMovingSpeed, 0, 0) * Time.deltaTime);

		float move = Input.GetAxis ("Horizontal");

		GetComponent<Rigidbody> ().velocity = new Vector2(move * maxS, GetComponent<Rigidbody>().velocity.y);

		if (move > 0 && !right)
			Flip ();
		else if (move < 0 && right)
			Flip();

		//------------ boundry set up


		//-------------
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			

			Jump();
		} 

		
			
	}

	void Flip()
	{
		right = !right;
		Vector3 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}


	void OnCollisionExit (Collision col)
	{
		if(col.gameObject.tag == "Ground"){
		}
			

	}

	void OnCollisionEnter (Collision col)
	{

		currentJumpNum = 0;
	}

	void Jump()
	{		
		if (currentJumpNum < maxJump) {
			GetComponent<Rigidbody> ().velocity = new Vector3 (GetComponent<Rigidbody> ().velocity.x, jumpHeight, 0f);
			currentJumpNum++;
		} 



	}




}

