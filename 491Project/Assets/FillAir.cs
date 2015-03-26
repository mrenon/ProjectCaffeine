using UnityEngine;
using System.Collections;

public class FillAir : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collision2D col)
	{
		Controller cont = GetComponent<Collider>().gameObject.GetComponent<Controller>();
		if (cont.gameObject.tag == "Player") {
			cont.currentHealth = cont.maxHealth;
			
		}
	}
}
