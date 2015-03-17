using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public float maxSpeed;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("left")){
			transform.Translate(-maxSpeed * Time.deltaTime,0,0);
		}
		if (Input.GetKey("right")){
			transform.Translate(maxSpeed * Time.deltaTime,0,0);
		}
	
	}
}
