using UnityEngine;
using System.Collections;

public class ParallaxWater : MonoBehaviour {

	public float speed = 0;
	public float hiddenTime;

	// Use this for initialization
	void Start () {
		//contPause.timeRemaining = 99999;
	}
	
	// Update is called once per frame
	void Update () {
		hiddenTime -= Time.deltaTime;

		if (hiddenTime > 0) {
			GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		}
		else if (hiddenTime <= 0) {
			PauseScroll ();
		} 
		//PauseScroll ();
		//GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Time.time * speed, 0f);

	}
	void PauseScroll()
	{

			StartCoroutine (PauseTime (1.0f)); 

	}
	
	/*IEnumerator PauseTime(float blinkTime)
	{
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		yield return new WaitForSeconds(blinkTime);
		speed = 0f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		yield return new WaitForSeconds(12.0f);
		speed = 0.03f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
	}*/
	IEnumerator PauseTime(float blinkTime)
	{
		speed = 0f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		yield return new WaitForSeconds(30.0f);
		speed = 0.015f;
		GetComponent<Renderer>().material.mainTextureOffset += new Vector2 (Time.deltaTime * speed, 0f);
		hiddenTime = 20.0f;
	}
}
