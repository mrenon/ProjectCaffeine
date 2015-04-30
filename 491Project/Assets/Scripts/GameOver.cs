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
		if (GUI.Button (new Rect (70, Screen.height/2 - 120, 200, 100), "")) {
			Application.LoadLevel("Whale");
		}
		else if (GUI.Button (new Rect (690, Screen.height/2 - 120, 200, 100), "")) {
			Application.LoadLevel("MainScreen");
		}
	}
}
