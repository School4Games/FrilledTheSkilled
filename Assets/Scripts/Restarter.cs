using UnityEngine;
using System.Collections;

public class Restarter : MonoBehaviour {

	private Spawnpointmanager manager;

	void Start()
	{
		manager = GameObject.Find ("SpawnPointManager").GetComponent<Spawnpointmanager> ();
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Player") 
		{
			manager.ResetPtoSpawn();
		}

	}
}
