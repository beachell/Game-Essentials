using UnityEngine;
using System.Collections;

public class MoveBG : MonoBehaviour {
	public float Speed = - 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3 (Speed, 0, 0) * Time.deltaTime);
	}
}
