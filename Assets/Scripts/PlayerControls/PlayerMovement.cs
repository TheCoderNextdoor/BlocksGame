using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//reference to player object
	public Rigidbody p1;

	public float sidewaysForce = 0.43f;
	public float forwardForce = 750.3f;
	bool stop = false;

	//move left right flags
	private bool rightMove=false;
	private bool leftMove=false;

	// Use this for initialization
	void Start () 
	{
		Debug.Log("Game started");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//get input from keyboard
		if(Input.GetKey("a"))
		{
			leftMove=true;
		}
		if(Input.GetKey("d"))
		{
			rightMove=true;
		}
	}

	//called each frame but preffered for physics calculations
	void FixedUpdate()
	{
		//move forward with increasing velocity
		if (stop == false) {
			p1.AddForce (0, 0, forwardForce * Time.deltaTime);
		} else 
		{
			p1.AddForce (0, 0, -forwardForce * Time.deltaTime);
		}

		if (leftMove) {
			//move left algorithm
			p1.AddForce (-sidewaysForce, 0, 0, ForceMode.VelocityChange);
			leftMove = !leftMove;
		}

		if (rightMove) {
			//move right algorithm
			p1.AddForce (sidewaysForce, 0, 0, ForceMode.VelocityChange);
			rightMove = !rightMove;
		}

		if (p1.position.y < -2f)	//if player falls over the edge
		{
			FindObjectOfType<GameManager> ().EndGame ();
		}

	}

	public void StopPlayer()
	{
		if (stop == false)
			stop = !stop;
	}
}
