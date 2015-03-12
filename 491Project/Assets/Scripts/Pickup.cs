using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour
{
	public AudioClip CollectSound ;
	static float score = 0f;
	public GUIText guiText;
	public GameObject particle ;

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "mushroom")
		
		{
			audio.PlayOneShot(CollectSound);
			Instantiate (particle, col.transform.position, col.transform.rotation );
			Destroy (col.gameObject);	
			score++;
			guiText.text = "Points: " + score + "/8";
		}

	}
}



//


