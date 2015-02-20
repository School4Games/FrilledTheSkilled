using UnityEngine;
using System.Collections;

public class Spawnpointmanager : MonoBehaviour {

	public GameObject[] spawnpoints;
	public GameObject Player;
	public GameObject startpoint;
	public GameObject activespawn;
	public int index = 0;
	// Use this for initialization
	void Start ()
	{
		spawnpoints = new GameObject[10];
		SetSpawn (startpoint);
	}
	public void SetSpawn(GameObject spawn)
	{
		activespawn = spawn;
		spawnpoints [index] = activespawn;
		index++;
	}

	public void ResetPtoSpawn ()
	{
		Player.transform.position = activespawn.transform.position;
	}
}
