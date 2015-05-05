using UnityEngine;
using System.Collections;

public class StartSkyGoDown : MonoBehaviour {

	public float speed = 1.0f;
	// Update is called once per frame
	void Update () {
		//this.transform.Translate(Vector2.right * Time.deltaTime * speed);
		BlinkPlayer();
	}
	
	void BlinkPlayer()
	{
		StartCoroutine (DoBlinks (9f));
		this.transform.Translate(Vector2.up * Time.deltaTime * 0);
	}
	
	IEnumerator DoBlinks(float blinkTime)
	{
		this.transform.Translate(Vector2.up * Time.deltaTime * 0);
		yield return new WaitForSeconds(blinkTime);
		this.transform.Translate(Vector2.up * Time.deltaTime * speed);
		yield return new WaitForSeconds(blinkTime);
		this.transform.Translate(Vector2.up * Time.deltaTime * 0);
		
	}
}
