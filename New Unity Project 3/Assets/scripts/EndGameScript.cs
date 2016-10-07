using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {


	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel ("BradBeachell");
		} 
	}
}
