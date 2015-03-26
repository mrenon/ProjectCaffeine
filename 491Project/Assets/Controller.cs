using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
	
	public float maxSpeed;
	public bool facingRight = false;
	public bool facingUp = false;
	public RectTransform healthTransform;
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis ("Vertical");
		
		if (Input.GetKey("left")){
			transform.Translate(-maxSpeed * Time.deltaTime,0,0);
		}
		if (Input.GetKey("right")){
			transform.Translate(maxSpeed * Time.deltaTime,0,0);
		}
		if (Input.GetKey("up")){
			transform.Translate(0, maxSpeed * Time.deltaTime,0);
		}
		if (Input.GetKey("down")){
			transform.Translate(0, -maxSpeed * Time.deltaTime,0);
		}
		
		if (h > 0 && !facingRight) 
			Flip ();

		else if(h < 0 && facingRight)
			Flip();
		
	}
	
	void Flip ()
	{
		// Switch the way the player is labelled as facing.
		facingRight = !facingRight;
		
		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

}
