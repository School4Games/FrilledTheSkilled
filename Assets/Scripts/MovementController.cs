using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour
{

	public float height = 750;
	public float maxSpeed = 750;
	public float move;
	public AudioClip ray_jump_03;
	private bool onFloor = false;
	bool facingRight = true;


	Animator anim;

	int jumpHash = Animator.StringToHash("Jump");
	int glideStateHash = Animator.StringToHash("Glide");

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
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown (KeyCode.Space))
		{
						Jump ();
						audio.PlayOneShot(ray_jump_03, 0.25f);
						anim.SetTrigger ("Jump");
		}

		//Gleiten
		if (Input.GetKey (KeyCode.Space)) 
		{
						transform.Translate (Vector3.up * 20 * Time.deltaTime, Space.World);
						anim.SetBool ("Glide", true);
		} 

		else
			{
				anim.SetBool("Glide", false);
			}

		float move = Input.GetAxis("Horizontal");

		//Aniamtion Control
		anim.SetFloat ("Speed", Mathf.Abs(move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		//move to right and left
			if (Input.GetKeyDown (KeyCode.A))
		{
			this.rigidbody2D.velocity = new Vector2 (-move, this.rigidbody2D.velocity.y);
			this.transform.TransformVector(Vector2.right);
		}

		if (Input.GetKeyDown (KeyCode.D))
		{
			this.rigidbody2D.velocity = new Vector2 (move, this.rigidbody2D.velocity.y);
		}
		if (move > 0 && !facingRight)
						Flip ();
				else if (move < 0 && facingRight)
						Flip ();



	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
			
}
