using UnityEngine;
using System.Collections;

public class MainScreen : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI()
	{
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (new Rect (60, Screen.height/2 + 280, 850, 80), "")) {
			Application.LoadLevel("Whale");
		}
	}
}
