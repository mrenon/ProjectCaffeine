using UnityEngine;
using System.Collections;

public class youwin : MonoBehaviour
{
	public GameObject splash;
	public GameObject particles;

	IEnumerator ReloadGame()
	{			
		// ... pause briefly
		yield return new WaitForSeconds(5);
		// ... and then reload the level.
		Application.LoadLevel(Application.loadedLevel);
	}
	
	
	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Player")
		{
			// ... reload the level.
			// 
			Instantiate (particles);
			Characterfinal.speed = 0;
			ReloadGame();
			//yield return new WaitForSeconds(3);
			Application.LoadLevel(Application.loadedLevel);
		}
		// Otherwise...
		else
		{

		

		}
	}
}