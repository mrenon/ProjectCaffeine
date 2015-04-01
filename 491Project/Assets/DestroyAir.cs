using UnityEngine;
using System.Collections;

public class DestroyAir : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "air") {
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
	}
}
