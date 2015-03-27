﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	
	public float maxSpeed;
	public bool facingRight = false;
	public bool facingUp = false;
	public RectTransform healthTransform;
	private float cachedY; // stores Y position
	private float minXValue;
	private float maxXvalue;
	public int currentHealth;
	
	private int CurrentHealth
	{
		get { return currentHealth;}
		set { 
			currentHealth = value; 
			HandleHealth();
		}
	}
	
	public int maxHealth;
	public Text healthText;
	public Image visualHealth;
	public float coolDown;
	private bool onCD;
	public Canvas canvas;
	
	void Start()
	{
		onCD = false;
		cachedY = healthTransform.position.y;
		maxXvalue = healthTransform.position.x;
		minXValue = healthTransform.position.x - healthTransform.rect.width * canvas.scaleFactor;
		currentHealth = maxHealth;
		
	}
	
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
		
		if (Input.GetKeyDown (KeyCode.Space)) {
			
			if(!onCD && currentHealth > 0)
			{
				StartCoroutine(CoolDownDmg());
				CurrentHealth -= 5;
			}
			
		}
		
		if (h > 0 && !facingRight) 
			Flip ();
		
		else if(h < 0 && facingRight)
			Flip();
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "air") {
			if(!onCD && currentHealth > 0)
			{
				StartCoroutine(CoolDownDmg());
				Destroy (col.gameObject);
					CurrentHealth += 5;
			}
		}
		if (col.gameObject.tag == "urchin") {
			if(!onCD && currentHealth > 0)
			{
				StartCoroutine(CoolDownDmg());
				CurrentHealth -= 10;
			}
		}
	}
	private void HandleHealth()
	{
		healthText.text = "Air: " + currentHealth;
		float currentXValue = MapValues (currentHealth, 0, maxHealth, minXValue, maxXvalue);
		healthTransform.position = new Vector3 (currentXValue, cachedY);
		
		if (currentHealth > maxHealth / 2) {  // Then i have more than 50% health
			visualHealth.color = new Color32((byte) MapValues(currentHealth, maxHealth/2, maxHealth,255,0),255,0,255);
		} 
		else // less than 50%
		{
			visualHealth.color = new Color32(255, (byte)MapValues(currentHealth, 0, maxHealth/2, 0, 255), 0, 255);
		}
	}
	
	IEnumerator CoolDownDmg()
	{
		onCD = true;
		yield return new WaitForSeconds(coolDown);
		onCD = false;
	}
	private float MapValues(float x, float inMin, float inMax, float outMin, float outMax)
	{
		return (x - inMin) * (outMax - outMin) / (inMax - inMin) + outMin;
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
