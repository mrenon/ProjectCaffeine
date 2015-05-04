using UnityEngine;
using System.Collections;

public class FartAnimChange : MonoBehaviour {
	
	Animator anim;
	bool hitFish; 
	bool moreThanOne;
	bool greenJellyx1;
	int fishCounter;
	
	
	//fish boolean variables
	bool greenfish_hit;
	bool orangefish_hit;
	bool fish_x2;
	bool fish_x3;
	bool fish_x4;
	bool fish_x5;
	bool fish_x6;
	bool fish_x7;
	bool fish_x8;
	bool fish_x9;
	bool fish_x10;
	public AudioSource fishPoint;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "fish") {//if fart hits a fish
			fishPoint.Play ();
			print ("fish hit");
			fishCounter++;
			if (fishCounter == 1) { //if counter is one change fart to fart with one fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("orangefish_hit", true);
				hitFish = anim.GetBool ("orangefish_hit");
			} else if (fishCounter == 2) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x2", true);
				moreThanOne = anim.GetBool ("fish_x2");
			} else if (fishCounter == 3) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x3", true);
				moreThanOne = anim.GetBool ("fish_x3");
			} else if (fishCounter == 4) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x4", true);
				moreThanOne = anim.GetBool ("fish_x4");
			} else if (fishCounter == 5) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x5", true);
				moreThanOne = anim.GetBool ("fish_x5");
			} else if (fishCounter == 6) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x6", true);
				moreThanOne = anim.GetBool ("fish_x6");
			} else if (fishCounter == 7) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x7", true);
				moreThanOne = anim.GetBool ("fish_x7");
			} else if (fishCounter == 8) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x8", true);
				moreThanOne = anim.GetBool ("fish_x8");
			} else if (fishCounter == 9) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x9", true);
				moreThanOne = anim.GetBool ("fish_x9");
			} else if (fishCounter == 10) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x10", true);
				moreThanOne = anim.GetBool ("fish_x10");
			}
			print (fishCounter);
		}
		else if(col.gameObject.tag == "Green_Fish") {//if fart hits a fish
			fishPoint.Play ();
			print ("fish hit");
			fishCounter++;
			if (fishCounter == 1) { //if counter is one change fart to fart with one fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("greenfish_hit", true);
				hitFish = anim.GetBool ("greenfish_hit");
			} else if (fishCounter == 2) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x2", true);
				moreThanOne = anim.GetBool ("fish_x2");
			} else if (fishCounter == 3) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x3", true);
				moreThanOne = anim.GetBool ("fish_x3");
			} else if (fishCounter == 4) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x4", true);
				moreThanOne = anim.GetBool ("fish_x4");
			} else if (fishCounter == 5) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x5", true);
				moreThanOne = anim.GetBool ("fish_x5");
			} else if (fishCounter == 6) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x6", true);
				moreThanOne = anim.GetBool ("fish_x6");
			} else if (fishCounter == 7) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x7", true);
				moreThanOne = anim.GetBool ("fish_x7");
			} else if (fishCounter == 8) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x8", true);
				moreThanOne = anim.GetBool ("fish_x8");
			} else if (fishCounter == 9) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x9", true);
				moreThanOne = anim.GetBool ("fish_x9");
			} else if (fishCounter == 10) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x10", true);
				moreThanOne = anim.GetBool ("fish_x10");
			}
			print (fishCounter);
		}
		
		
		else if (col.gameObject.tag == "jellyfishgreen") {
			fishPoint.Play();
			fishCounter++;
			if(fishCounter == 1){
				anim = GetComponent<Animator>();
				anim.SetBool ("greenJellyx1", true);
				greenJellyx1 = anim.GetBool("greenJellyx1");
			}
		}
	}
}
