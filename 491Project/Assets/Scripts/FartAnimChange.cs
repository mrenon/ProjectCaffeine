using UnityEngine;
using System.Collections;

public class FartAnimChange : MonoBehaviour {

	Animator anim;
	bool hitFish; 
	bool moreThanOne;
	bool greenJellyx1;
	int fishCounter;
	public AudioSource fishPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "fish") {//if fart hits a fish
			fishPoint.Play();
			print ("fish hit");
			fishCounter++;
			if (fishCounter == 1) { //if counter is one change fart to fart with one fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("hitFish", true);
				hitFish = anim.GetBool ("hitFish");
			} else if (fishCounter > 1) { //if counter is one > change fart to fart with alot of fish
				anim = GetComponent<Animator> ();
				anim.SetBool ("moreThanOne", true);
				moreThanOne = anim.GetBool ("moreThanOne");
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
