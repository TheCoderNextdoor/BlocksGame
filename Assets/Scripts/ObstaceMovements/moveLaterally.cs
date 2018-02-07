using UnityEngine;

public class moveLaterally : MonoBehaviour {

	//opening speed
	public int speed = 10;
	//direction variable
	public short dir;
	//stores the rigidbody component of this block
	Rigidbody block;
	Vector3 movement;

	// Use this for initialization
	void Start () {
		
		//get the rigidbody to move
		block = GetComponent<Rigidbody> ();
		//movement vector is in the "right" direction
		movement = Vector3.right;
		moveBlock (dir);
	}

	//move in a direction specified by direction -1,1
	void moveBlock(short direction)
	{
		block.velocity = direction * speed * movement;
	}
}
