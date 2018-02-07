using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	//PlayerMovement object reference to disble the corresponding script
	//public PlayerMovement move;

	void OnCollisionEnter(Collision colliderInfo){
		if (colliderInfo.collider.tag == "Obstacle") 
		{
			GetComponent<PlayerMovement>().enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
