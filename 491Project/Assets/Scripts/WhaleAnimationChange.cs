using UnityEngine;
using System.Collections;

public class WhaleAnimationChange : MonoBehaviour {

	
	Animator anim;
	bool upSwim;
	bool downSwim;
	bool fartFace;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("down")) {
			anim = GetComponent<Animator> ();
			anim.SetBool ("downSwim", true);
			downSwim = anim.GetBool ("downSwim");
			if(Input.GetKey("space")){
				anim = GetComponent<Animator>();
				anim.SetBool("fartFace", true);
				fartFace = anim.GetBool("fartFace");
			}
			//anim.SetTrigger("downSwimTrig");
		} else if (Input.GetKey ("up")) {
			anim = GetComponent<Animator> ();
			anim.SetBool ("upSwim", true);
			upSwim = anim.GetBool ("upSwim");
			if(Input.GetKey("space")){
				anim = GetComponent<Animator>();
				anim.SetBool("fartFace", true);
				fartFace = anim.GetBool("fartFace");
			}
			//anim.SetTrigger("upSwimTrig");
		} else if (Input.GetKey ("space")) {
			anim = GetComponent<Animator>();
			anim.SetBool("fartFace", true);
			fartFace = anim.GetBool("fartFace");
		}
		else if(!Input.GetKey ("down") || !Input.GetKey("up") ||
		        !Input.GetKey("space")) {
			anim.SetBool("downSwim", false);
			anim.SetBool("upSwim", false);
			anim.SetBool("fartFace",false);
			downSwim = anim.GetBool("downSwim");
			upSwim = anim.GetBool("upSwim");
			fartFace = anim.GetBool("fartFace");
		}
		
	}
}
