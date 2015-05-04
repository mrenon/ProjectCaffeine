using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	
	public float maxSpeed;
	//public 
	public bool facingRight = false;
	public bool facingUp = false;
	public RectTransform healthTransform;
	private float cachedY; // stores Y position
	private float minXValue;
	private float maxXvalue;
	public int currentHealth;
	public Text alertText;

	public float timeRemaining = 99999;
	private bool alertactive = true;

	private int score = 0; // player score

	bool turnOffTimer = true;
	bool damaged;
	public GameObject alert;
	
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
	public Renderer renderer;
	public Renderer alertRenderer;
	public AudioSource fart;
	public AudioSource hurtWhale;
	public AudioSource eatBubble;
	public float flashSpeed = 5f;
	Color[] colors = new Color[] {Color.white, Color.red, Color.green, Color.blue};
	private int currentColor,length;


	void OnGUI() {

			if (turnOffTimer) {
			if (timeRemaining > 0) {
				GUI.Label (new Rect (125, 30, 150, 100), "" + (int)timeRemaining);
			} else {
				GUIStyle myStyle = new GUIStyle();
				myStyle.fontSize = 40;
				if (score >= 100) { // if player score is over 100pts.  we can change the score player has to reach later
					GUI.Label (new Rect (140, 330, 150, 100), "YOU WIN!", myStyle);
				} else {
					GUI.Label (new Rect (120, 330, 150, 100), "GAME OVER!", myStyle);

				}
				GUI.Label (new Rect (140, 280, 150, 100), "TIMES UP!", myStyle);
			}
		}

		if (currentHealth <= 0) {
			GUIStyle myStyle = new GUIStyle ();
			myStyle.fontSize = 40;
			turnOffTimer = false;
			//GUI.Label (new Rect (38, 280, 150, 100), "GAME OVER. NO AIR!", myStyle);
			Application.LoadLevel("GameOver");
		} else if (currentHealth > 0 && currentHealth <= 30) {
			BlinkAlert();
			//
			// RENON!!!!!
			//  PUT CODE HERE!!!
			//
			//
		} 
	}
	void Start()
	{
		//alert.SetActive(false);
		alertText.enabled = false;
		alertRenderer.enabled = !alertRenderer.enabled;
		onCD = false;
		cachedY = healthTransform.position.y;
		maxXvalue = healthTransform.position.x;
		minXValue = healthTransform.position.x - healthTransform.rect.width * canvas.scaleFactor;
		currentHealth = maxHealth;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (currentHealth <= 0) {
			GUIStyle myStyle = new GUIStyle();
			myStyle.fontSize = 100;
			//GUI.Label (new Rect (350, 350, 150, 100), "GAME OVER. NO AIR!", myStyle);
			Application.LoadLevel("GameOver");
		}
		else if (currentHealth > 0 && currentHealth <= 30) {
		}

		timeRemaining -= Time.deltaTime;
		Controller cont = gameObject.GetComponent<Controller>();
		if (cont.currentHealth <= 0) {
			GUI.Label (new Rect (250, 300, 150, 100), "GAME OVER!");
		}


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
			fart.Play();
			if(!onCD && currentHealth > 0)
			{
				//StartCoroutine(CoolDownDmg());
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
			eatBubble.Play ();
			if (!onCD && currentHealth > 0) {

				{
					StartCoroutine (CoolDownDmg ());
					CurrentHealth += 10;
					Destroy (col.gameObject);
				}
				//Destroy (col.gameObject);
			}
		}
		currentColor = 0; //White
		length = colors.Length;
		if (col.gameObject.tag == "urchin") {
			damaged = true;
			currentColor = (currentColor+1)%length;
			renderer.material.color = colors[currentColor];
			hurtWhale.Play();
			CurrentHealth -= 10;
			BlinkPlayer();
			Destroy (col.gameObject);
		}
		StartCoroutine (CoolDownDmg ());
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

	void BlinkPlayer()
	{
		StartCoroutine (DoBlinks (10f, 0.1f));
	}

	IEnumerator DoBlinks(float duration, float blinkTime)
	{
		while (duration > 0f) {
			duration -= Time.deltaTime;
		}
		renderer.enabled = !renderer.enabled;
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = true; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = false; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = true; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = false; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = true;
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = true; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = false; 
		yield return new WaitForSeconds(blinkTime);
		renderer.enabled = true;
		
	}

	void BlinkAlert()
	{
		StartCoroutine (DoBlinks2 (1.0f)); 

	}

	IEnumerator DoBlinks2(float blinkTime)
	{
		//alertText.enabled = true;
		alertRenderer.enabled = !alertRenderer.enabled;
		yield return new WaitForSeconds(blinkTime);
		alertRenderer.enabled = true;
		alert.SetActive(true);
		yield return new WaitForSeconds(blinkTime);
		//alertText.enabled = false;
		alertRenderer.enabled = !alertRenderer.enabled;
		alert.SetActive(false);
	}
	
	IEnumerator CoolDownDmg()
	{
		onCD = true;
		coolDown = 1.0f;
		yield return new WaitForSeconds(coolDown);
		currentColor = 0; //White
		renderer.material.color = colors[currentColor];
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
