using UnityEngine;
using System.Collections;

public class LeftLegMove : MonoBehaviour {

	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 5f;				// The fastest the player can travel in the x axis.



	void Update()
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		//grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  

	}


	void FixedUpdate ()
	{

		if (Input.GetButtonDown ("moveLeftLeg")) 
		{
			float h = Input.GetAxis ("Horizontal");
			h = 0.02f;
			GetComponent<Rigidbody2D> ().AddForce(Vector2.up * h * moveForce, ForceMode2D.Impulse);
			// If the player is changing direction (h has a different sign to velocity.x) or hasn't reached maxSpeed yet...
			/*
			if (h * GetComponent<Rigidbody2D> ().velocity.y < maxSpeed)
			// ... add a force to the player.
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * h * moveForce);

			// If the player's horizontal velocity is greater than the maxSpeed...
			if (Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x) > maxSpeed)
			// ... set the player's velocity to the maxSpeed in the x axis.
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (Mathf.Sign (GetComponent<Rigidbody2D> ().velocity.x) * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
*/

		}
		if (Input.GetButtonDown ("left")) {
			Debug.Log ("btn3");
		}
		if (Input.GetButtonDown ("right")) {
			Debug.Log ("btn2");
		}
	}


}