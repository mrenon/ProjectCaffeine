using UnityEngine;
using System.Collections;

public class DestroyAir : MonoBehaviour {
	//public Transform bulletPrefab;
	void Start() {
	//	Transform bullet = Instantiate(bulletPrefab) as Transform;
		//Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "air") {
			//Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
		if (col.gameObject.tag == "jellyfishgreen") {
			//Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
		if (col.gameObject.tag == "urchin") {
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}
		if (col.gameObject.tag == "jellyfishgreen") {
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "Green_Fish") {
			Destroy (col.gameObject);
			//	fishTotal = fishTotal + 1;
		}

		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "urchin") {
			Destroy (col.gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "fish") {
			Destroy (collider.gameObject);
		}
		if (collider.gameObject.tag == "Green_fish") {
			Destroy (collider.gameObject);
		}
		if (collider.gameObject.tag == "jellyfishgreen") {
			Destroy (collider.gameObject);
		}
	}
}
