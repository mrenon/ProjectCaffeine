using UnityEngine;
using System.Collections;

public class ParallaxWater : MonoBehaviour {

	public float speed = 0;
	Controller contPause = new Controller();

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);
		PauseScroll ();
	}
	void PauseScroll()
	{
		if (contPause.timeRemaining == 99990) {
			StartCoroutine (PauseTime (1)); 
		}
	}
	
	IEnumerator PauseTime(float blinkTime)
	{
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		yield return new WaitForSeconds(blinkTime);
		speed = 0f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		yield return new WaitForSeconds(12.0f);
		speed = 0.03f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
	}
}
