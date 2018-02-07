using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	//speed of movemnet
	public float moveSpeed = 2;
	//maximum movement
	public float moveAmplitude = 1;
	//phase of movement
	public float offset = 45;


	Vector3 rightVector;
	Rigidbody m_rigidBody;
	Collider collide;

	// Use this for initialization
	void Start () {
		//get the rigidbody and collider components of the gameobject
		m_rigidBody = GetComponent<Rigidbody>();
		collide = GetComponent<Collider> ();

		//set the movement speed of the velocity vector
		rightVector = moveAmplitude * Vector3.right;

		//create a new material and make it slippery
		PhysicMaterial m_physicMaterial = new PhysicMaterial();
		m_physicMaterial.dynamicFriction = 0;
		m_physicMaterial.staticFriction = 0;

		//set the physics material of the collider
		collide.material = m_physicMaterial;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//i've used a sine function to get the oscillations and map them to the movement speed of the gameobject's rigidbody
		m_rigidBody.velocity = rightVector * Mathf.Sin(Time.fixedTime * moveSpeed + offset);
	}
}
