using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	public float playerSpeed = 5.0f;


	void Start () {

		transform.position = new Vector3 (0, 3, 0);
	
	}
	

	void Update () {

		transform.Translate (Vector3.right * Input.GetAxis ("Horizontal") * playerSpeed * Time.deltaTime);

		if (Input.GetKeyDown (KeyCode.Space)) {
			this.transform.rigidbody2D.AddForce (new Vector2 (0, 50.0f));
		if (Input.GetKeyDown (KeyCode.Space)) {
				this.transform.rigidbody2D.AddForce (new Vector3 (0, 100.0f));
			}
		}
	
	}
}
