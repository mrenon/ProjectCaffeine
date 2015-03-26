using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	int fishTotal = 0;

	// Use this for initialization
	void Start () {
		//int fishTotal = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int hp = 1000;
	
	public bool isEnemy = true;
	
	void OnTriggerEnter2D(Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
		
		if (shot != null || shot.tag == "fish") {
			Destroy (shot.gameObject);
			fishTotal = fishTotal + shot.fish;
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);
		//	fishTotal = fishTotal + 1;
		}
	}

	void OnGUI() {
		GUI.Label (new Rect (250, 300, 150, 100), "Score!" + fishTotal);
	}
}
