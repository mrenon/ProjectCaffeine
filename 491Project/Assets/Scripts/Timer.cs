using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	// TIMER counting DOWN
	float timer = 60.0f;
	float timerMax = 3.0f;
	void Start()
	{
		timer = timerMax ;
	}
	void Update()
	{
		timer -= Time.deltaTime;
		
		if (timer < 0)
		{
			Debug.Log("timer Zero reached !");
			
			// reset timer
			timer = timerMax;
		}
	}

}
