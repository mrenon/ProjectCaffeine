using UnityEngine;
using System.Collections;

public class SpawnFishLeftToRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float speed = 3.0f;
	// Update is called once per frame
	void Update () {
		this.transform.Translate(-Vector2.right * Time.deltaTime * speed);
	}
}
