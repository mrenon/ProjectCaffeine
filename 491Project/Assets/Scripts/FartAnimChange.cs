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
		if(fishCounter == 0){
			if(col.gameObject.tag == "fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("orangefish_hit", true);
				hitFish = anim.GetBool ("orangefish_hit");
			}
			if(col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("greenfish_hit", true);
				hitFish = anim.GetBool ("greenfish_hit");
			}
			if(col.gameObject.tag == "Pink_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("orangejelly_hit", true);
				hitFish = anim.GetBool ("orangejelly_hit");
			}
			if(col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("greenjelly_hit", true);
				hitFish = anim.GetBool ("greenjelly_hit");
			}
		}
		else if(fishCounter == 1){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x2", true);
				moreThanOne = anim.GetBool ("fish_x2");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x2", true);
				moreThanOne = anim.GetBool ("jelly_x2");
			}
		}
		else if(fishCounter == 2){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x3", true);
				moreThanOne = anim.GetBool ("fish_x3");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x3", true);
				moreThanOne = anim.GetBool ("jelly_x3");
			}
		}
		else if(fishCounter == 3){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x4", true);
				moreThanOne = anim.GetBool ("fish_x4");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x4", true);
				moreThanOne = anim.GetBool ("jelly_x4");
			}
		}
		else if(fishCounter == 4){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x5", true);
				moreThanOne = anim.GetBool ("fish_x5");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x5", true);
				moreThanOne = anim.GetBool ("jelly_x5");
			}
		}
		else if(fishCounter == 5){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x6", true);
				moreThanOne = anim.GetBool ("fish_x6");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x6", true);
				moreThanOne = anim.GetBool ("jelly_x6");
			}
		}
		else if(fishCounter == 6){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x7", true);
				moreThanOne = anim.GetBool ("fish_x7");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x7", true);
				moreThanOne = anim.GetBool ("jelly_x7");
			}
		}
		else if(fishCounter == 7){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x8", true);
				moreThanOne = anim.GetBool ("fish_x8");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x8", true);
				moreThanOne = anim.GetBool ("jelly_x8");
			}
		}
		else if(fishCounter == 8){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x9", true);
				moreThanOne = anim.GetBool ("fish_x9");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x9", true);
				moreThanOne = anim.GetBool ("jelly_x9");
			}
		}
		else if(fishCounter == 9){
			if(col.gameObject.tag == "fish" || col.gameObject.tag == "Green_Fish"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("fish_x10", true);
				moreThanOne = anim.GetBool ("fish_x10");
			}
			else if(col.gameObject.tag == "Pink_Jelly" || col.gameObject.tag == "Green_Jelly"){
				fishPoint.Play();
				fishCounter++;
				anim = GetComponent<Animator> ();
				anim.SetBool ("jelly_x10", true);
				moreThanOne = anim.GetBool ("jelly_x10");
			}
		}
	}
}
