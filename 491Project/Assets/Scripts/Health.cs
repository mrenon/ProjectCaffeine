using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public int startHealth;
	public int healthPerHeart;
	public GameObject[] heartGUI;

	// Use this for initialization
	void Start () {
		AddHearts (startHealth / healthPerHeart);
	}

	public void AddHearts(int n)
	{
		for (int i = 0; i < n; i++) {
			GameObject.Instantiate(heartGUI[i]);
		}
	}

	public void ModifyHealth(int amount)
	{

	}
}
