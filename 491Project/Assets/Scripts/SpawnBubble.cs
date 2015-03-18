using UnityEngine;
using System.Collections;

public class SpawnBubble : MonoBehaviour {

	// Use this for initialization
	public float speed = 3.0f;
	// Update is called once per frame
	void Update () {
		this.transform.Translate(Vector2.up * Time.deltaTime * speed);
	}

}
