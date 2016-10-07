using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {



	void OnCollisionEnter (Collision col)
	{
		Application.LoadLevel ("BradBeachell");

	}
}
