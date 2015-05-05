using UnityEngine;
using System.Collections;

public class MainScreen : MonoBehaviour {
	private bool isLoaded = false;
	private string mainlevel;
	// Use this for initialization
	void Start () {
		mainlevel = PlayerPrefs.GetString("Whale");
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Application.LoadLevel("Whale");
		}
		
	}
	
	void OnGUI()
	{
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (new Rect (60, Screen.height/2 + 280, 850, 80), "")) {

		}
	}
}
