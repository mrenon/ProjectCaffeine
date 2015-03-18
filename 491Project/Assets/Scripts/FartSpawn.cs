using UnityEngine;
using System.Collections;

public class FartSpawn : MonoBehaviour {

	public Vector3 ObjectSpawnPosition;
	public GameObject obj;
	//public GameObject Player;
	
	void Update(){
		ObjectSpawnPosition = GameObject.FindWithTag("Player").transform.position;

		if(Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(obj, ObjectSpawnPosition, Quaternion.identity);
		}
	}
}

