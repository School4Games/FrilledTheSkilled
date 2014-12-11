using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour{

	public float height = 750;
	public float speed;
	private bool onFloor = false;

	void OnCollisionEnter2D(Collision2D collision)
	{
		foreach (var contactPoint in collision.contacts) 
		{
			if (contactPoint.normal.y > 0.9)
			{
				onFloor = true;
			}
		}
	}

	void Jump ()
	{
		if (canJump ()) 
		{
			onFloor = false;

			Vector2 jumpForce = new Vector2 (0, height);
			this.rigidbody2D.AddForce (jumpForce);
		}
	}

	bool canJump()
	{
		return onFloor;
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Jump();
		}

		//move to right and left
			if (Input.GetKey (KeyCode.A)) {
			this.rigidbody2D.velocity = new Vector2 (-speed, this.rigidbody2D.velocity.y);
		}
		if (Input.GetKey (KeyCode.D)) {
			this.rigidbody2D.velocity = new Vector2 (speed, this.rigidbody2D.velocity.y);
		}
	}
}
