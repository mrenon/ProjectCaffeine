using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (new Rect (50, Screen.height/2 - 100, 130, 100), "")) {
			Application.LoadLevel("Whale");
		}
		else if (GUI.Button (new Rect (760, Screen.height/2 - 100, 130, 100), "")) {
			Application.LoadLevel("MainScreen");
		}
	}
}
