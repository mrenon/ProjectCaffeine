using UnityEngine;
using System.Collections;

public class UrchinHealth : MonoBehaviour {

	public int hp = 1000;
	public bool isEnemy = true;
	
	void OnTriggerEnter2D(Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

		if (shot != null || shot.tag == "fish") {
			Destroy (shot.gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
			
		}
	}
}
