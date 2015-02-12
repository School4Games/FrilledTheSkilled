using UnityEngine;
using System.Collections;

public class loadMenue : MonoBehaviour 
{

	public bool player;

	void OnTriggerEnter2D(Collider2D other)
	{
		Application.LoadLevel ("Menue");
	}

}
