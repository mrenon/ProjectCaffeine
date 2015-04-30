using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

	public int fishTotal = 0;

	// Use this for initialization
	void Start () {
		//int fishTotal = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int hp = 1000;
	
	public bool isEnemy = true;
	
	void OnTriggerEnter2D(Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
		
		if (shot != null || shot.tag == "fish") {
			Destroy (shot.gameObject);
			if(shot.fish == 0) {
				fishTotal = fishTotal + (shot.fish * 0);

				//animation change to Fishx1
			}
			else if(shot.fish == 1) {
				fishTotal = fishTotal + (shot.fish * 1);
				//animation change to Fishx2
			}
			else if(shot.fish == 2) {
				fishTotal = fishTotal + (shot.fish * 2);
				//animation change to Fishx3
			}
			else if(shot.fish == 3) {
				fishTotal = fishTotal + (shot.fish * 3);
				//animation change to Fishx4
			}
			else if(shot.fish == 4) {
				fishTotal = fishTotal + (shot.fish * 3);
				//animation change to Fishx5
			}
			else if(shot.fish == 5) {
				fishTotal = fishTotal + (shot.fish * 5);
				//animation change to Fishx6
			}
			else if(fishTotal == 6) {
				fishTotal = fishTotal + (shot.fish * 6);
				//animation change to Fishx7
			}
			else if(fishTotal == 7) {
				fishTotal = fishTotal + (shot.fish * 7);
				//animation change to Fishx8
			}
			else if(fishTotal == 8) {
				fishTotal = fishTotal + (shot.fish * 8);
				//animation change to Fishx9
			}
			else if(fishTotal == 9) {
				fishTotal = fishTotal + (shot.fish * 9);
				//animation change to Fishx10
			}
		}
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "fish") {
			Destroy (col.gameObject);

		//	fishTotal = fishTotal + 1;
		}
	}

	void OnGUI() {
		// left/right, up/down
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 40;
		GUI.contentColor = Color.white;
		GUI.Label (new Rect (580, 0, 150, 100), " " + fishTotal, myStyle);
	}
}
