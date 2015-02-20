using UnityEngine;
using System.Collections;

public class Spawntrigger : MonoBehaviour {

	public Spawnpointmanager manager;

	void Start()
	{
		manager = GameObject.FindGameObjectWithTag("Checkpointsys").GetComponent<Spawnpointmanager> ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("is in Collider");
		if(other.tag == "Player")
		{
			Debug.Log("is dead");
			manager.SetSpawn(this.gameObject);
			Destroy(this.gameObject.collider2D);
		}
	}
}
