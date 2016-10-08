using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnCactus : MonoBehaviour {

	public List<GameObject> Cactus = new List <GameObject>();

	//float i = Random.Range(0f, 1f);

	/*
	void Randomizer()
	{
		float i= new Random.Range (0f, 1f);
	}

	void Awake () {
		Debug.Log ("script ran");
		//Randomizer ();
		if (i == 1f) {
			Debug.Log ("I've spawned");
		}


	}*/



	public Vector3 spawnValues;
	public int rangeValues =8;

	int platformNumbers = 1;
	float spawnWait =0;
	float startWait = 0;
	//float waveWait = 0;
	int x = 0;
	// Use this for initialization
	void Start()
	{
		StartCoroutine (SpawnWaves());

	}

	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (x<1) {
			for (int i = 0; i < platformNumbers; i++) {
				Vector3 spawnPosition = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
				Quaternion spwanRotation = Quaternion.identity;
				Instantiate (Cactus[Random.Range(0, rangeValues)], spawnPosition, spwanRotation);
				//yield return new WaitForSeconds (waveWait);
				x++;
			}

		}
	}

}
