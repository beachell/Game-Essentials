using UnityEngine;
using System.Collections;

public class DestroyGamePieces : MonoBehaviour {
	//public float gravityForces = - 20;


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "boundry") {
			Destroy (gameObject);
		} /*else {
			
			Physics.gravity = new Vector3 (0,gravityForces, 0 );
		}*/
			
	}
}
