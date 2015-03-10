using UnityEngine;
using System.Collections;

public class FireHitAction : MonoBehaviour {

	public Animation anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animation> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey("a"))
		{
			anim.Play("fire_hit");
	
		}
		//if (!Input.GetKey ("a")) {
		//	anim.Play ()
		/// play idle animation
		//}
}
}