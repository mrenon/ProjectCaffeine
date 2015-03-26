using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int fish = 0;
	public int damage = 1;
	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20);
	}

}
