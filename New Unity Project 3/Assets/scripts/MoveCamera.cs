using UnityEngine;
using System.Collections;


public class MoveCamera : MonoBehaviour {



	public float cameraSpeed = - 2.0f;
	public float lifetime = 20.0f;

	void Start()
	{
		Destroy (this.gameObject, lifetime);
	}


	void Update ()
	{
		transform.Translate (new Vector3 (cameraSpeed, 0, 0) * Time.deltaTime);
	}




}