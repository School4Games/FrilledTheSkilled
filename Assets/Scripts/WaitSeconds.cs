using UnityEngine;
using System;
using System.Collections;

public class WaitSeconds : MonoBehaviour
{
	void Start()
	{
		StartCoroutine (SomeCoroutine());
	}

	// C# coroutine
	IEnumerator SomeCoroutine () {
			
		// Wait for two seconds
		yield return new WaitForSeconds (10);
		Application.LoadLevel("Menue");

	}

}
