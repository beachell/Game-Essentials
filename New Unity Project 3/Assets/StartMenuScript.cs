using UnityEngine;
using System.Collections;

public class StartMenuScript : MonoBehaviour {

/*-------- notes
 needs to launch on double click
	*/

	public void TaskOnClick(){
		print ("click");
		Application.LoadLevel ("BradBeachell");
	}


}



