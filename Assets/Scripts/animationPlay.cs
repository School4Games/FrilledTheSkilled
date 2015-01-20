using UnityEngine;
using System.Collections;

public class animationPlay : MonoBehaviour
{
	public GameObject movingPlatform;
	public bool playAnimation;
	void OnTriggerEnter2D(Collider2D other)
	{
		movingPlatform.animation.Play();
		//movingPlatform.animation.Play ("NewLevel01_JumpSisters_3", PlayMode.StopAll);
		Debug.Log ("play Animation");
	}

}
