using UnityEngine;
using System.Collections;

public class SpawnCloudLeft : MonoBehaviour {
	
	public float speed = 3.0f;
	// Update is called once per frame
	void Update () {
		//this.transform.Translate(Vector2.right * Time.deltaTime * speed);
		BlinkPlayer();
	}

	void BlinkPlayer()
	{
		StartCoroutine (DoBlinks (104f)); // was 49
	}
	
	IEnumerator DoBlinks(float blinkTime)
	{
		this.transform.Translate(Vector2.right * Time.deltaTime * 0);
		yield return new WaitForSeconds(blinkTime);
		this.transform.Translate(Vector2.right * Time.deltaTime * speed);
		
	}
}
