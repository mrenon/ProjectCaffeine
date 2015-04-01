using UnityEngine;
using System.Collections;

public class FillAir : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider) {
		Controller cont = collider.gameObject.GetComponent<Controller>();
		
		if (cont != null || cont.tag == "Player") {
			cont.currentHealth = cont.maxHealth;
		}
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
	}
}
