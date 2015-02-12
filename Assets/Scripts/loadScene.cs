using UnityEngine;
using System.Collections;


//Play animation on Trigger Enter
public class loadScene : MonoBehaviour
{

	public bool player;

	void OnTriggerEnter2D(Collider2D other) 
	{
		Application.LoadLevel ("Credits");
	}
}
