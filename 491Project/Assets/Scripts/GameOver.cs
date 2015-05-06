﻿using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public int y = Screen.height/2 - 90;
	public int x = 790;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (new Rect (50, Screen.height/2 - 100, 190, 140), "")) { // button pressed
			Application.LoadLevel("MainScreen");
		}
	}
}
