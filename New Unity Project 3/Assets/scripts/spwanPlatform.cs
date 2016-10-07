using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class spwanPlatform : MonoBehaviour {

	/*public string platformName;
	public int platformNumValue;
	public string */
	public List<GameObject> PlatformList = new List <GameObject>();
	//public GameObject platform;


	public Vector3 spawnValues;
	public int rangeValues = 5;

	public int platformNumbers = 4;
	public float spawnWait =1;
	public float startWait = 1;
	public float waveWait = 1;

	// Use this for initialization
	void Start()
	{
		StartCoroutine (SpawnWaves());

	}
	
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < platformNumbers; i++) {
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
				Quaternion spwanRotation = Quaternion.identity;
				Instantiate (PlatformList[Random.Range(0, rangeValues)], spawnPosition, spwanRotation);
				yield return new WaitForSeconds (waveWait);
			}

		}
	}
}

/*----------designer notes------------------
 * With the number of platforms we have 6 at the moment. set the spawn values to x= 15 y=-5 z=0
 * 
 * range values at 6
 * spwan wait at 1
 * start wait at 1
 * wave wait at 1.998 for best grouping. May need to rework models again if they are not lining up again. 
 * */