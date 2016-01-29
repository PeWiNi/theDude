using UnityEngine;
using System.Collections;

public class RightLegMove : MonoBehaviour {
	public float moveForce = 365f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 5f;				// The fastest the player can travel in the x axis.




	private Transform groundCheck;			// A position marking where to check if the player is grounded.
	private bool grounded = false;			// Whether or not the player is grounded.
	public bool facingRight = true;


	void Awake()
	{
		// Setting up references.
		groundCheck = transform.Find("groundCheck");

	}


	void Update()
	{
		// The player is grounded if a linecast to the groundcheck position hits anything on the ground layer.
		//grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));  

	}


	void FixedUpdate ()
	{

		if (Input.GetButtonDown ("moveRightLeg")) 
		{
			Debug.Log ("Button pressed rightLeg" + Input.GetButtonDown ("moveRightLeg")); 
			float h = 0.02f;

			GetComponent<Rigidbody2D> ().AddForce(Vector2.up * h * moveForce, ForceMode2D.Impulse);
		}
	}


}