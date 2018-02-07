using UnityEngine;

public class FollowCamera : MonoBehaviour {

	//Transform object to get player position details
	//Vector3 object to store camera offset
	public Transform player;
	public Vector3 offset;

	// Update is called once per frame
	void Update () {
		
		//transform refers to current script object, ie. the camera
		transform.position = player.position  + offset;
	}
}
