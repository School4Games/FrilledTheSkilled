using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
	public float speed = 1.0f;
	void FixedUpdate(){
		if (Input.GetKey (KeyCode.A)) {
			this.transform.rigidbody2D.AddForce (new Vector2 (-speed, 0));
		} else if (Input.GetKey (KeyCode.D)) {
			this.transform.rigidbody2D.AddForce (new Vector2 (speed, 0));
		}
		
		if(Input.GetKeyDown (KeyCode.Space)){
			this.transform.rigidbody2D.AddForce(new Vector2(0,100.0f));}
	}
}